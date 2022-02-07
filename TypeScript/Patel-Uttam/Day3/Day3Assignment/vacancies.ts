console.log('Vacancies');


    let Vacancy_tuple:[number,string]
    let Vacancy_array:Array<[number,string]>=[];

    export class Class_Vacancy
    {
        Display_Vacancy():void
        {
            for(var items in Vacancy_array)
            {
                console.log("Current "+items[0]+" Vacancy for "+items[1] );
            }
        }

        Add_Vacancy(count:number,vacancy:string):void
        {
            Vacancy_tuple=[count,vacancy];
            Vacancy_array.push(Vacancy_tuple);
            console.log(count+" Vacancy for "+vacancy); 
        }


    }