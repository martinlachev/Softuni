/**
 * Created by MartinLachev on 6/20/2016.
 */
function ProductOfThree(arr) {

    let count = 0;
    for (let i = 0; i < arr.length; i++) {
        if(arr[i]<0){
            count++;
        }
        if(arr[i]==0){
            return "Positive";
        }

    }
    if(count %2 != 0){
        return "Negative"
    }
    else {
        return "Positive"
    }




}