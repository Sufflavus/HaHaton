MarksSite.viewmodels.markNewPage = function ($, ko) {

    function Mark(model) {
        var self = this;
        self.fromId = model.FromId;
        self.toId = model.ToId;
        self.from = model.From;
        self.to = model.To;
        self.date = model.Date;

        self.markDetails = {
            Productivity: {
                Value: ko.observable(),
                Comment: ko.observable(),
            },
            Quality: {
                Value: ko.observable(),
                Comment: ko.observable(),
            },
            Discipline: {
                Value: ko.observable(),
                Comment: ko.observable(),
            },
            Cooperation: {
                Value: ko.observable(),
                Comment: ko.observable(),
            },
            Skills: {
                Value: ko.observable(),
                Comment: ko.observable(),
            },
            Initiative: {
                Value: ko.observable(),
                Comment: ko.observable(),
            },
            Growth: {
                Value: ko.observable(),
                Comment: ko.observable(),
            }
        };

        self.markType = [
            {
                id: 0,
                value: "O"
            },
            {
                id: 1,
                value: "EE"
            },
            {
                id: 2,
                value: "S"
            },
            {
                id: 3,
                value: "NI"
            },
            {
                id: 4,
                value: "U"
            }
        ];
    }

    function bindMarkList(model) {        
        ko.applyBindings(new Mark(model));
    }

    return {
        bindMarkList: bindMarkList
    };
}(jQuery, ko);