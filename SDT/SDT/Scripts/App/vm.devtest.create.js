define("vm.devtest.create",
    ["ko", "notify","model.devtest", "dataservice.devtest"],
    function (ko, notify, devtest, service) {
        var model = new devtest(),
            errors = ko.validation.group(model),
            hasError = ko.computed(function() {
                return errors().length > 0;
            }),
            dirtyFlag = new ko.DirtyFlag(model),
            isDirty = ko.computed(function() {
                 return dirtyFlag().isDirty();
            }),

            create = function () {
                if (hasError()) {
                    errors.showAllMessages(); 
                    return;
                }
                service.create({
                    success: function (data) {
                        notify.success('Dev test created.');
                        reset();
                    },
                    error: function (data) {
                        notify.error('Error to create dev test.');
                    }
                }, model);
            },

            reset = function () {
                model.campaingnName("");
                model.date("");
                model.clicks("");
                model.conversions("");
                model.impressions("");
                model.affiliateName("");
                errors.showAllMessages(false);
                dirtyFlag().reset();
            };

        return {
            model: model,
            isDirty: isDirty,
            create: create,
            reset: reset
        };
    });