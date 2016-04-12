define("vm.devtest.list",
    ["ko", "notify", "dataservice.devtest"],
    function (ko, notify, service) {

        var devtests = ko.observableArray([]),
            load = function() {
                service.all({
                    success: function(data) {
                        devtests(data);
                    },
                    error: function() {
                        notify.error();
                    }
                });
            },
            remove = function(item) {
                service.remove({
                    success: function () {
                        notify.success('Dev test removed.');
                        devtests.remove(item);
                    },
                    error: function () {
                        notify.error();
                    }
                }, item);
            },
            confirmToRemove = function(item) {
                notify.confirm("Are you sure, you want to delete the stuent ?", function (result) {
                    if (result === true) {
                        remove(item);
                    }
                });
            };
        
        return {
            models: devtests,
            load: load,
            confirmToRemove: confirmToRemove
        };

    });