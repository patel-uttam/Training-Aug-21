
let Interviews:Array<[number,string]>=[];
let Interview:[number,string];
export function Schedule_Iterview(Applicant:Array<string|number>,interviewer:string ):void
{
    Interview = [parseInt(Applicant[0].toString()),interviewer];
    Interviews.push(Interview);
}

export function Display_Interview():void
{
    for(var i in Interviews)
    {
        console.log("Interview for Applicant ID "+Interviews[i][0]+" schedule with "+Interviews[i][1]);
    }
}
