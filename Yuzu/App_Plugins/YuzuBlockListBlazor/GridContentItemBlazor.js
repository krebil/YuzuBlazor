angular.module('umbraco')
    .controller('GridContentItemBlazor', function ($scope, $element, $window, yuzuDeliveryBlockListResources) {

        var loadPreview = function () {
            let blockData = $scope.block.data;
            var json = JSON.stringify(blockData, getCircularReplacer())
            let data = {content: json, contentTypeKey: blockData.contentTypeKey};

            $scope.content = json;
            $scope.contentTypeKey = blockData.contentTypeKey;
            console.log("contentTypeKey",$scope.contentTypeKey)

            $scope.$watch('block.data', function (newValue, oldValue) {
                if (newValue != oldValue) {
                    loadPreview();
                }
            }, true);
        }

        loadPreview();

    });

function getCircularReplacer() {
    const seen = new WeakSet();
    return (key, value) => {
        if (key === "$block")
            return null;
        if (typeof value === "object" && value !== null) {
            if (seen.has(value)) {
                return;
            }
            seen.add(value);
        }
        return value;
    };
};