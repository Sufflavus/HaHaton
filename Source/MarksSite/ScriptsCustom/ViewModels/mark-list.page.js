MarksSite.viewmodels.markListPage = function ($, ko) {

    function Mark(model) {
        var self = this;
        self.from = model.From;
        self.to = model.to;
        self.date = model.Date;
        self.markDetails = model.MarkDetails
    }

    function bindMarkList(model) {
        var marks=model.map(function (item) {
            return new Mark(item);
        })
        var viewModel = {
            marks: marks
        };
        ko.applyBindings(viewModel);
    }

    return {
        bindMarkList: bindMarkList
    };
}(jQuery, ko);