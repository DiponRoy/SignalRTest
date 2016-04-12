define("vm.devtest",
    ["jquery", "model.devtest", "vm.devtest.create", "vm.devtest.update", "vm.devtest.list", "hubservice.devtest"],
    function ($, devtestModel, create, update, list, devtestHub) {
        /*section place*/
        var sections = {
            create: '#divSectionCreate',
            update: '#divSectionUpdate',
            list: '#divSectionList'
        },
        translate = function (sectionToShow, sectionToHide) {
            $(sectionToHide).fadeOut().hide();
            $(sectionToShow).fadeOut().show();
        },
        showToCreate = function () {
            translate(sections.create, sections.list);
        },
        showToUpdate = function (item) {
            update.load(item.id());
            translate(sections.update, sections.list);
        },
        createDone = function () {
            translate(sections.list, sections.create);
        },
        updateDone = function () {
            translate(sections.list, sections.update);
        };        

        /*notifications from hub*/
        devtestHub.client.created(function (model) {
            var devtest = new devtestModel();
            devtest.id(model.Id);
            devtest.campaingnName(model.CampaingnName);
            devtest.date(model.Date);
            devtest.clicks(model.Clicks);
            devtest.conversions(model.Conversions);
            devtest.impressions(model.Impressions);
            devtest.affiliateName(model.AffiliateName);
            list.models.push(devtest);
        });
        devtestHub.client.updated(function (model) {
            var devtest = list.getById(model.Id);
            devtest.id(model.Id);
            devtest.campaingnName(model.CampaingnName);
            devtest.date(model.Date);
            devtest.clicks(model.Clicks);
            devtest.conversions(model.Conversions);
            devtest.impressions(model.Impressions);
            devtest.affiliateName(model.AffiliateName);
        });
        devtestHub.client.removed(function (model) {
            var devtest = list.getById(model.Id);
            list.models.remove(devtest);
        });

        return {
            createVm: create,
            updateVm: update,
            listVm: list,

            showToCreate: showToCreate,
            showToUpdate: showToUpdate,
            createDone: createDone,
            updateDone: updateDone,            
        };
    });