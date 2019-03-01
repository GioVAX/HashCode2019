using System;
using System.Collections.Generic;
using System.Linq;

namespace HashCode.Photos
{
    public class SlideShow
    {
        private Slide[] _bestSolution = null;
        private int _solutionLength = 0;
        private int _bestScore = -1;

        public IEnumerable<Slide> Compose(List<Slide> slides)
        {
            _bestSolution = new Slide[slides.Count];

            Recursive(new List<Slide>(), 0, slides);

            return _bestSolution;
        }

        private void Recursive(IEnumerable<Slide> solution, int currentScore, List<Slide> availableSlides)
        {
            
            for (var i = 0; i < availableSlides.Count; ++i)
            {
                Console.WriteLine("Current length: " + _solutionLength + " best: " + _bestScore);

                var slide = availableSlides[i];
                var currentTransitionScore = solution.Any() ? TagScorer.Score(new HashSet<string>(solution.Last().Tags),
                    new HashSet<string>(slide.Tags)) : 0;

                if (_solutionLength != 0 && currentTransitionScore == 0)
                    continue;

                var newSolution = solution.Append(slide);


                CheckBestSolution(newSolution, currentTransitionScore + currentScore);

                Recursive(newSolution, currentTransitionScore + currentScore, availableSlides.Where(sl => sl != slide).ToList());
            }
        }

        private void CheckBestSolution(IEnumerable<Slide> solution, int score)
        {
            if (score <= _bestScore)
                return;

            solution.ToList().CopyTo(_bestSolution);
            _solutionLength = solution.Count();
            _bestScore = score;
        }

        private int ComputeScore(List<Slide> solution)
        {
            var score = 0;
            for (var i = 0; i < solution.Count - 1; ++i)
                score += TagScorer.Score(new HashSet<string>(solution[i].Tags), new HashSet<string>(solution[i + 1].Tags));
            return score;
        }
    }
}
