import React from "react";
import Paper from "@material-ui/core/Paper"
import Typography from "@material-ui/core/Typography"

export class Week_7_component extends React.Component {
  render() {
    return (

      <Paper className={"content"}>
        <Typography variant = "h4" color="inherit" component="h4">
          Săptămâna a 7-a
        </Typography>

        <Typography component="p" align="justify">
          Am conceput arhitectura proiectului și am stabilit tehnologiile folosite - Unity și Python. Am împărțit aplicațiile în submodule, am stabilit flow-urile de lucru și am făcut repository-urile Github ale proiectului. Am stabilit repartiția membrilor grupei în echipe. 
        </Typography> 
      </Paper>

    );
  }
}
