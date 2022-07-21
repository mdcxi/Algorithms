using System.Collections.Generic;
using System;

public class TournamentWinner {
    
    public int HOME_TEAM_WON = 1;
    
    public string FindTournamentWinner (List<List<string> > competitions, List<int> results) 
    {
        //competitions = [ ["HTML", "C#"], ["C#", "Python"], ["Python", "HTML"]]
        //results = [0, 0, 1]
        
        string currentBestTeam = "";
        Dictionary <string, int> scores = new Dictionary <string, int>();
        scores[currentBestTeam] = 0; 

        for (int i = 0; i < competitions.Count; i++)
        {
            List<string> competition = competitions [i];
            int result = results[i];

            string homeTeam = competition[0];
            string awayTeam = competition[1];
            string winTeam = (result == HOME_TEAM_WON) ? homeTeam : awayTeam;

            updateScores (winTeam, 3, scores);

            if (scores[winTeam] > scores[currentBestTeam])
            {
                currentBestTeam = winTeam;
            }
        }
        return currentBestTeam;
    }

    public void updateScores ( string team, int points, Dictionary<string, int> scores)
    {
        if (!scores.ContainsKey(team))
        {
            scores[team] = 0;
        }
        scores[team] += points;
    }
}
