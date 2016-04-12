define("vm.devtest",
    ["jquery", "vm.devtest.create", "vm.devtest.update", "vm.devtest.list"],
    function ($, create, update, list) {
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
            update.load(item.id);
            translate(sections.update, sections.list);
        },
        createDone = function () {
            translate(sections.list, sections.create);
        },
        updateDone = function () {
            translate(sections.list, sections.update);
        };


        return {
            createVm: create,
            updateVm: update,
            listVm: list,

            showToCreate: showToCreate,
            showToUpdate: showToUpdate,
            createDone: createDone,
            updateDone: updateDone
        };
    });