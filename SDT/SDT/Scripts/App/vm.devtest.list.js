define("vm.devtest.list",
    ["ko", "notify", "model.devtest", "dataservice.devtest"],
    function (ko, notify, devtestModel, service) {

        var devtests = ko.observableArray([]),
            load = function() {
                service.all({
                    success: function(list) {
                        var arr = new Array();
                        $.each(list, function (index) {
                            var model = new devtestModel();
                            ko.mapping.fromJS(list[index], {}, model);
                            arr.push(model);
                        });
                        devtests(arr);
                    },
                    error: function() {
                        notify.error();
                    }
                });
            },
            getById = function (id) {
                var value = $.grep(devtests(), function (obj) {
                    return obj.id() === id;
                });
                return value[0];
            },
            remove = function(item) {
                service.remove({
                    success: function () {
                        notify.success('Dev test removed.');
                    },
                    error: function () {
                        notify.error();
                    }
                }, ko.mapping.toJS(item));
            },
            confirmToRemove = function(item) {
                notify.confirm("Are you sure, you want to delete?", function (result) {
                    if (result === true) {
                        remove(item);
                    }
                });
            };
        
        return {
            models: devtests,
            load: load,
            getById: getById,
            confirmToRemove: confirmToRemove
        };

    });