import React from "react";
import Paper from "@material-ui/core/Paper"
import Typography from "@material-ui/core/Typography"

export class Week_8_component extends React.Component {
  render() {
    return (

      <Paper className={"content"}>
        <Typography variant = "h4" color="inherit" component="h4">
          Săptămâna a 8-a
        </Typography>
      
        <Typography component="p" align="justify">
          Am început să ne organizăm mai mult la nivel de grupe. Am ales lideri, am distribuit oameni la submodule și ne-am făcut table Kanban pe Meistertask pentru gestionarea task-urilor. Am definitivat comunicarea dintre front și back, structura json a fișierelor care descriu modelul 3D și sculptura Lego, precum și modul de funcționare al aplicațiilor.
        </Typography> 
      </Paper>

    );
  }
}
