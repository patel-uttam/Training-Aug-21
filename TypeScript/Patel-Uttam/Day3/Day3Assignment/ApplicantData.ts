
    console.log('ApplicantData');

    interface DataInsert_interface
    {
        Applicants:Array<string|number>[];
    
        ApplicantData:Array<string|number>;

        ApplicantID:number;
        ApplicantName:string;
        ApplicantPassingYear:number;
        ApplicantDegree:string;
        ApplicantCGPA:number;
        ApplicantCollege:string;
        ApplyFor:string;


        
    }

    export class DataInsert implements DataInsert_interface
    {
        Applicants:Array<string|number>[]=[];
        ApplicantData:Array<string|number>=[];

        ApplicantID:number;
        ApplicantName:string;
        ApplicantPassingYear:number;
        ApplicantDegree:string;
        ApplicantEngineering:string;
        ApplicantCGPA:number;
        ApplicantCollege:string;
        ApplyFor:string;
        


        Insert_Data(id:number , name:string , passingyear:number , degree:string , cgpa:number , college:string ,apply:string):void
        {
            this.ApplicantID=id;
            this.ApplicantName=name;
            this.ApplicantPassingYear=passingyear;
            this.ApplicantDegree=degree;
            this.ApplicantCGPA=cgpa;
            this.ApplicantCollege=college;
            this.ApplyFor=apply

            this.ApplicantData.push(this.ApplicantID);
            this.ApplicantData.push(this.ApplicantName);
            this.ApplicantData.push(this.ApplicantPassingYear);
            this.ApplicantData.push(this.ApplicantDegree);
            this.ApplicantData.push(this.ApplicantCGPA);
            this.ApplicantData.push(this.ApplicantCollege);
            this.ApplicantData.push(this.ApplyFor);

            this.Applicants.push(this.ApplicantData);
            this.ApplicantData = [];
            
        }

        Display_Data():void
        {
            console.log("Id"+'  |  '+"Name"+'  |  '+"Passing Year"+'  |  '+"Degree"+'  |  '+"CGPA"+'  |  '+"College"+'  |  '+"Apply for");
            console.log('\n');
            for(var i in this.Applicants)
            {
                console.log(this.Applicants[i][0]+'\t'+this.Applicants[i][1]+'\t'+this.Applicants[i][2]+'\t'+this.Applicants[i][3]+'\t'+this.Applicants[i][4]+'\t'+this.Applicants[i][5]+'\t'+this.Applicants[i][6]);
            }
        }

        // Display_
        // Delete_Data(id:number):void
        // {

        //     // delete this.Applicants[this.Applicants.findIndex(this.Applicants)]
        //     // this.Applicants = this.Applicants.filter(this.Applicants);
        // }
        
    }
