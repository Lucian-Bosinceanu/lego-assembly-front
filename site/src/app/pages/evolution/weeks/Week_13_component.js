import React from "react";
import Paper from "@material-ui/core/Paper"
import Typography from "@material-ui/core/Typography"

export class Week_13_component extends React.Component {
  render() {
    return (

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Săptămâna a 13-a
          </Typography>

          <Typography component="p" align="justify">
          S-a remarcat un efort al echipei de back-end în testarea și fixarea funcționalității de input al fișierelor care descriu modele 3D. În plus, s-a lucrat la fixarea și
imbunătățirea algoritmului genetic de îmbinare al cuburilor.
          </Typography> 
        </Paper>

    );
  }
}
