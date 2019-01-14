import React from "react";
import Paper from "@material-ui/core/Paper"
import Typography from "@material-ui/core/Typography"

export class Week_9_component extends React.Component {
  render() {
    return (

      <Paper className={"content"}>
        <Typography variant = "h4" color="inherit" component="h4">
          Săptămâna a 9-a
        </Typography>
      
        <Typography component="p" align="justify">
        Ne-am apucat propriu-zis de implementarea funcționalităților de bază. Pe front s-au definitivat cu succes construcția și ștergerea cuburilor, gestionarea camerei și interfața. S-au făcut progrese în validarea construcției și în prezentarea, dar care nu au fost încă integrate. Gestionarea IO și modelarea pieselor de Lego au fost reprogramate pentru săpămâna următoare, pe lângă alte îmbunătățiri generale. 
  Echipa de la back-end a reușit de implementat o primă iterație a tuturor modulelor, urmând o perioadă de integrare și de testare. 
  Cei de la testare au realizat mai multe fișiere json cu scopul de a fi folosite ca date de test de către cei de la back-end, urmând ca de acum să realizeze și câteva sculpturi lego pentru testarea funcționalităților de pe front.
  La nivel de administrare, au fost purtate discuții cu echipele tehnice pentru a definitiva structurile de date folosite la nivel de back-end, precum și anumiți algoritmi de identificare a pieselor și a rotațiilor lor. În plus, a început implementarea acestui site.
        </Typography> 
      </Paper>

    );
  }
}
