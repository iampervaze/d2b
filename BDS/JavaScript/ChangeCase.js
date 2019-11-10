const Case = { Lower: 1, Upper: 2, Pascal: 3 };
function ChangeCase() {
}
ChangeCase.convert = function (cas, words) {
    let outString = "";
    switch (cas) {
        case Case.Lower: // lowercase
            for (var i = 0; i < words.length; i++)
                outString += words[i].toLowerCase();
            break;

        case Case.Upper: // UPPERCASE
            for (var i = 0; i < words.length; i++)
                outString += words[i].toUpperCase();
            break;

        case Case.Pascal: //PascalCase
            for (var i = 0; i < words.length; i++) {
                outString += words[i].substring(0, 1).toUpperCase();
                outString += words[i].substring(1).toLowerCase();
            }
            break;
    }
    return outString;
}

module.exports = {
    ChangeCase,
    Case
}