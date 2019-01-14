import React from "react";
import Paper from "@material-ui/core/Paper"
import Typography from "@material-ui/core/Typography"

export class Week_10_component extends React.Component {
  render() {
    return (

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Săptămâna a 10-a
          </Typography>

          <Typography component="p" align="justify">
          S-a lucrat îndeosebi pe partea de front-end, unde s-au integrat la întregul proiect funcționalități realizate în săptămâna a 9-a, precum ștergerea cuburilor și
modificări la UI. S-au implementat și funcționalități noi, precum un mecanism de contorizare al cuburilor, dar și posibilitatea de a le șterge. Echipa de la testare a 
implementat un program care să genereze fișiere JSON invalide pentru back-end.
          </Typography> 
        </Paper>

    );
  }
}
