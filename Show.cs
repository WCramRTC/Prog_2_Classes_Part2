using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_2_Classes_Part2
{
    public class Show
    {
		/*
         * - Hafsa - Watch Shows
	- Episodes
	- Name
	- Name of Episode
	- Captions
	- Description
	- Runtime
	- Season
	- Ratings
         */

		string _name;
		string _nameOfEpisode;
		string _captions;
		string _descrption;
		int _runtime;
		string _season;
		float _ratings;

        public Show(string name, string nameOfEpisode, string captions, string descrption, int runtime, string season, float ratings)
        {
            _name = name;
            _nameOfEpisode = nameOfEpisode;
            _captions = captions;
            _descrption = descrption;
            _runtime = runtime;
            _season = season;
            _ratings = ratings;
        }

        public string Name { get => _name; set => _name = value; }
        public string NameOfEpisode { get => _nameOfEpisode; set => _nameOfEpisode = value; }
        public string Captions { get => _captions; set => _captions = value; }
        public string Descrption { get => _descrption; set => _descrption = value; }
        public int Runtime { get => _runtime; set => _runtime = value; }
        public string Season { get => _season; set => _season = value; }
        public float Ratings { get => _ratings; set => _ratings = value; }




    }
}
