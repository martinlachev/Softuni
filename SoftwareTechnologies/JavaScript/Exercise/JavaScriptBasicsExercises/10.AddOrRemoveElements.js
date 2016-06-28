/**
 * Created by MartinLachev on 6/21/2016.
 */
function AddOrRemoveElements(arr) {

    let list = [];
    let temp = [];

    for (let i = 0; i < arr.length; i++) {
        temp = arr[i].split(" ");
        if(temp[0] == 'add'){
            list.push(temp[1]);
        }
        if(temp[0] == 'remove'){
            list.splice(Number(temp[1]),1);
        }

    }
    for (let i = 0; i < list.length; i++) {

        console.log(list[i]);
    }

}


