define('hubService',
    ['jquery', "ko", "notify"],
    function($, ko, notify) {
        /*Hub connections*/
        var connectionId = ko.observable(''),
            connect = function() {
                $.connection.hub.start()
                    .done(function() {
                        connectionId($.connection.hub.id);
                    });
            };

        return {
            connect: connect,
            connectionId: connectionId,
        };
    });