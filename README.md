Kroz vježbu kolegija Razvoj poslovnih aplikacija radit će se jednostavna aplikacija za bicikle koja podržava unos, uređivanje, brisanje, pretragu i opis bickla u bazi. Aplikacija također, treba omogućiti brisanje i prikaz detalja pojedinog bicikla. Svaki unos podataka kroz aplikaciju treba uključivati provjeru valjanosti i za brisanje podataka je potrebna posebna potvrda korisnika.
Aplikaciji će moći pristupiti svi korisnici koji imaju internet i internet preglednik te žele pristupiti svim bitnim informacijama vezano za bicikle na jednom centraliziranom mjestu.
Stvorit će se jedna centralna baza podataka o biciklima dostupna svima. Korisnici kada budu htjeli potražiti informacije o biciklima neće više morati pretraživati putem Google-a i koristiti više izbora za dobivanje informacija o nekom biciklu jer će kroz aplikaciju moći dobiti sve potrebne informacije na jednom mjestu. Aplikacija će biti dostupna putem interneta, zahvaljujući tome korisnik ima mogućnost korištenja aplikacije u bilo koje vrijeme
Aplikacija mora omogućiti spremanje, uređivanje, pretraživanje, prikaz, traženje i brisanje bicikala ubazi podataka.
U kasnijem razvoju aplikacije razvit će se sigurna identifikacija i zaštićena autentikacija gdje korisnička imena i lozinke ne smiju biti spremljena u obična tekstualna polja i datoteke, a ostali podaci korisnika kao što su adresa, telefonski brojevi, brojevi kreditnih kartica neće biti dostupni anonimnim pristupom.
Slučajevi korištenja opisuju scenarije u kojima korisnici web aplikacije koriste predloženu aplikaciju za upravljanje biciklima. U tim slučajevima korištenja su uključene osnovne operacije, stoga ih ne treba smatrati konačnim. Kako napreduje razvoj dodatna funkcionalnost može biti dodana prema odluci SCRUM mastera	
Kada posjetitelj stranice pregledava Bicikle koji se nalaze u web aplikaciji, odvijaju se sljedeći koraci:
1.	Posjetitelj dolazi na početnu stranicu web mjesta kao anonimni korisnik ili klikne na link Početna stranica u izborniku ako se nalazio na drugoj stranici na istom web mjestu.
2.	Početna stranica prikazuje osnovni opis web aplikacije i sadrži gumbe za prikaz, pretraživanje i dodavanje novih bicikala. 
3.	Prikaz osnovnih informacija o razvojnom timu moguće je dobiti putem stranica O nama i Kontakt.
4.	Ako anonimni korisnik želi vidjeti sve Bicikle u bazi, mora kliknuti na link Popis bicikala u glavnom izborniku ili gumb prikaži na Početnoj stranici.
5.	Web aplikacija prikazuje popis bicikala. Za svaki Bicikl se prikazuje Naziv bicikla, Godina proizvodnje, Kategorija te Cijena.
6.	Ako anonimni korisnik želi pretraživati Bicikle u bazi po Kategoriji i Nazivu, mora kliknuti na link Tražilica bicikla u glavnom izborniku.
7.	 Ako anonimni korisnik želi vidjeti detalje Bicikla, mora kliknuti na link Detalji za taj Bicikl.
8.	Web aplikacija prikazuje detalje odabranog bicikla –Naziv bicikla, Godina proizvodnje Bicikla, Kategorija te Cijenu.
Svi korisnici trebaju moći dodati novi Bicikl. Kada korisnik dodaje novi Bicikl, sljedeći koraci se odvijaju:
1.	Korisnik klikne na gumb Unos na Početnoj stranici ili na link Novi bicikl na stranicama Popis bicikala ili Tražilica bicikala.
2.	Korisnik upisuje podatke o novom Biciklu.
3.	Korisnik klikne na gumb Spremi.
4.	Ako su upisani podaci ispravni, web aplikacija sprema Bicikl u bazu i vraća korisnika na stranicu Popis bicikla
Kada korisnik uređuje Bicikl, sljedeći koraci se odvijaju:
1.	Korisnik klikne na link Uredi u popisu bicikala na stranicama Popis bicikala ili  Tražilica bicikala.
2.	Korisnik mijenja postojeće podatke o biciklu.
3.	Korisnik klikne gumb Spremi promjene.
4.	Ako su upisani podaci točni, web aplikacija sprema promjene u bazi i prikazuje stranicu za Popis bicikala
Kad korisnik briše bicikle iz baze podataka web aplikacije, sljedeći koraci se odvijaju:
1.	Korisnik klikne na link Obriši u popisu bicikala na stranicama Popis bicikala ili  Tražilica bicikala.
2.	Web aplikacija zahtijeva potvrdu o brisanju bicikla.
3.	Ako korisnik potvrđuje brisanje, bicikl je uklonjen iz baze.
4.	Web aplikacija prikazuje stranicu Popis bicikala
