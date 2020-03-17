$(document).ready(function () {
    $('[data-toggle="tooltip"]').tooltip();
});

String.prototype.replaceAll = function (s1, s2) {
    return this.replace(
        new RegExp(s1.replace(/[.^$*+?()[{\|]/g, '\\$&'), 'g'),
        s2
    );
};

String.prototype.toCamelCase = function () {
    var trimmedString = this.replace(/[^A-Z0-9]/ig, "");
    return trimmedString[0].toLowerCase() + trimmedString.substring(1);
};  

var removeValueFromCommaSeparatedString = function (list, value, separator) {
    console.log(list);
    separator = separator || ",";
    var values = list.split(separator);
    for (var i = 0; i < values.length; i++) {
        if (values[i] == value) {
            values.splice(i, 1);
            return values.join(separator);
        }
    }
    return list;
}