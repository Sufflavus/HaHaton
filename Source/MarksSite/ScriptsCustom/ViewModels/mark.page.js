MarksSite.viewmodels.markPage = function ($, ko) {

    function Mark(model) {
        var self = this;
        self.from = model.From;
        self.to = model.to;
        self.date = model.Date;
        self.markDetails = model.MarkDetails
    }

    function bindMark(model) {
        var mark = new Mark(model);
        ko.applyBindings(mark);
    }

    return {
        bindMark: bindMark
    };
}(jQuery, ko);