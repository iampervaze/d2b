export enum Case { Lower, Upper, Pascal };
export class ChangeCase {
    static convert(cas, words) {
        let outstring: string = "";
        switch (cas) {
            case Case.Lower: // lowercase
                for (var i = 0; i < words.length; i++)
                    outstring += words[i].toLowerCase();
                break;

            case Case.Upper: // UPPERCASE
                for (var i = 0; i < words.length; i++)
                    outstring += words[i].toUpperCase();
                break;

            case Case.Pascal: //PascalCase
                for (var i = 0; i < words.length; i++) {
                    outstring += words[i].substring(0, 1).toUpperCase();
                    outstring += words[i].substring(1).toLowerCase();
                }
                break;
        }
        return outstring;
    }
}
