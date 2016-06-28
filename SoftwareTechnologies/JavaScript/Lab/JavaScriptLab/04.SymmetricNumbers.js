/**
 * Created by MartinLachev on 6/20/2016.
 */

function symetricNumbers(arr) {
    let n = Number(arr[0]),result = ''
    for (var i = 0; i < n; i++) {
        if(isSymetric(""+i)){
            result += i + " "
        }
        console.log(result)

    }
    function isSymetric(str){
        for (var i = 0; i < str.length; i++) {
            if(str[i] != str[str.length - i - 1]){
                return false
            }
            else {
                return true
            }
        }

    }
}
symetricNumbers(['1000'])