/**
 * Created by MartinLachev on 6/21/2016.
 */
function SetValuesToIndexesInArray(arr) {

    let arraySize = Number(arr[0]);

    let otherArr = new Array(arraySize);

    for (let i= 1; i < arr.length; i++) {
        let postion = '';
        let value = '';
        for (let j = 0; j < arr[i].length; j++) {
             postion = arr[i].charAt(0);
            value = Number(arr[i].charAt(arr[i].length-2) + arr[i].charAt(arr[i].length-1)) ;

        }
        otherArr[postion] = value;

    }

    for (let i = 0; i < otherArr.length; i++) {

        if(typeof otherArr[i] == 'undefined'){
            otherArr[i]=0;
        }
        console.log(otherArr[i]);

    }




    

}

