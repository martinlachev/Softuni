/**
 * Created by MartinLachev on 6/22/2016.
 */
function setObjects(arr) {
    let obj = {};
    for(let i = 0; i < arr.length; i++){
        let str = arr[i].split(' -> ');
        obj[str[0]] = str[1];
        if(str[0] == "grade"){
            obj[str[0]] = Math.round(parseInt(str[1]));
        }
        if(str[0] == "age"){
            obj[str[0]] = Math.round(parseInt(str[1]));
        }
    }
    console.log(JSON.stringify(obj));
}