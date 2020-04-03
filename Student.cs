namespace LibrarieEntitati

{ using System;

    public class Student
    {
        // date membre private
        string nume;
        int[][] note;

        // contructor implicit
        public Student()
        {
        }

        // constructor cu parametri
        public Student(string _nume)
        {
            nume = _nume;
        }

        //set note

        public void SetNote(string sirNote)
        {
            // initializare vector cu note
            string[] a = sirNote.Split(',');
            string[] q;
            int j = 0;
            note = new int[a.Length][];
            //note[i] = new int[a.Length];
            for (int i = 0;i<a.Length;i++)
            {
                q = a[i].Split(' ');
                note[i] = new int[q.Length];
                for (j = 0; j < q.Length; j++)
                    note[i][j] = Convert.ToInt32(q[j]);
            }
            // DE IMPLEMENTAT:
            // extrage note din sir si adauga in vectorul note

        }

        public string ConversieLaSir()
        {
            int x = note.Length;
            int y = note.Rank;
            string sNote = "Nu exista (Nu ati apelat metoda **setNote**)";
            for (int i = 0; i < x; i++)
            {
                for(int j = 0;j<y;j++)
                sNote = string.Join(",", note[i]);
                string s = string.Format("Studentul {0} are notele:.... {1}", nume, sNote);
                Console.WriteLine(string.Format("Studentul {0} are notele:.... {1} in anul {2}", nume, sNote,i+1));
                    }
            return sNote;
            }
        }
}
