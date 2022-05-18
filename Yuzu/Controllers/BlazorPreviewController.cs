using System;
using System.Collections.Generic;
using System.Linq;
using BlazorExample.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Our.Umbraco.DocTypeGridEditor.Helpers;
using Our.Umbraco.DocTypeGridEditor.Models;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.BackOffice.Controllers;
using Umbraco.Cms.Web.Common.Attributes;
using YuzuDelivery.Core;
using YuzuDelivery.Umbraco.Core;

namespace Yuzu.Controllers;

public class BlazorBlockListPreviewController : ControllerBase
{
    private readonly IYuzuDefinitionTemplates yuzuDefinitionTemplates;
    private readonly IMapper mapper;
    private readonly IYuzuConfiguration config;
    private readonly IContentTypeService contentTypeService;
    private readonly DocTypeGridEditorHelper docTypeGridEditorHelper;

    public BlazorBlockListPreviewController(IMapper mapper, IYuzuConfiguration config,
        IYuzuDefinitionTemplates yuzuDefinitionTemplates, IContentTypeService contentTypeService
        , DocTypeGridEditorHelper docTypeGridEditorHelper
    )
    {
        this.mapper = mapper;
        this.config = config;
        this.yuzuDefinitionTemplates = yuzuDefinitionTemplates;
        this.contentTypeService = contentTypeService;
        this.docTypeGridEditorHelper = docTypeGridEditorHelper;
    }

    [HttpPost]
    [Route("/Api/BlazorBlockListPreview/GetPartialData")]
    public PreviewReturn GetPartialData([FromForm] PreviewDTO data)
    {
        var output = new PreviewReturn();
        try
        {
            var contentType = contentTypeService.Get(Guid.Parse(data.ContentTypeKey));

            var model = docTypeGridEditorHelper.ConvertValueToContent(Guid.NewGuid().ToString(), contentType.Alias,
                data.Content);


            var modelType = config.CMSModels.FirstOrDefault(x => contentType.Alias.FirstCharacterToUpper() == x.Name);

            var suspectBlockTypeName = $"{YuzuConstants.Configuration.BlockPrefix}{model.ContentType.Alias.FirstCharacterToUpper()}";

            var vmType = config.ViewModels.FirstOrDefault(x => x.Name == suspectBlockTypeName);

            if (vmType == null)
            {
                output.Error =
                    $"Viewmodel for block type {suspectBlockTypeName} not found. Previews of sublocks not supported";
            }
            else
            {
                output.Preview = yuzuDefinitionTemplates.Render(new RenderSettings()
                {
                    Data = () => mapper.Map(model, modelType, vmType,new Dictionary<string, object>(){{"Model", model}, {_BlockList_Constants.IsInPreview, true}}),
                    Template = yuzuDefinitionTemplates.GetSuspectTemplateName(modelType)
                });
            }
        }
        catch (Exception ex)
        {
            output.Error = ex.Message;
        }

        return output;
    }
}