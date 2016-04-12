define('hubservice.devtest',
    ['jquery'],
    function ($) {
        var hub = $.connection.devTestsHub;
        /*get notifications from hub*/
        var client = {
            created: function (callBackFunction) {
                hub.client.create = function (devtest) {
                    callBackFunction(devtest);
                };
            },
            updated: function (callBackFunction) {
                hub.client.update = function (devtest) {
                    callBackFunction(devtest);
                };
            },
            removed: function (callBackFunction) {
                hub.client.remove = function (devtest) {
                    callBackFunction(devtest);
                };
            }
        };

        return {
            client : client,
        };
    });