/* 
 * WebAPI
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: data
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = ACUtils.AXRepository.ArxivarNext.Client.SwaggerDateConverter;

namespace ACUtils.AXRepository.ArxivarNext.Model
{
    /// <summary>
    /// JoinDmDatiProfilo
    /// </summary>
    [DataContract]
    public partial class JoinDmDatiProfilo :  IEquatable<JoinDmDatiProfilo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JoinDmDatiProfilo" /> class.
        /// </summary>
        /// <param name="legameTabella">legameTabella.</param>
        /// <param name="id">id.</param>
        /// <param name="docnumber">docnumber.</param>
        /// <param name="campo">campo.</param>
        /// <param name="valore">valore.</param>
        /// <param name="contatti">contatti.</param>
        /// <param name="fax">fax.</param>
        /// <param name="tel">tel.</param>
        /// <param name="indirizzo">indirizzo.</param>
        /// <param name="mail">mail.</param>
        /// <param name="localita">localita.</param>
        /// <param name="cap">cap.</param>
        /// <param name="provincia">provincia.</param>
        /// <param name="nazione">nazione.</param>
        /// <param name="codice">codice.</param>
        /// <param name="contatto">contatto.</param>
        /// <param name="mansione">mansione.</param>
        /// <param name="telnome">telnome.</param>
        /// <param name="faxnome">faxnome.</param>
        /// <param name="cell">cell.</param>
        /// <param name="abitazione">abitazione.</param>
        /// <param name="reparto">reparto.</param>
        /// <param name="ufficio">ufficio.</param>
        /// <param name="email">email.</param>
        /// <param name="riferimento">riferimento.</param>
        /// <param name="codfis">codfis.</param>
        /// <param name="partiva">partiva.</param>
        /// <param name="priorita">priorita.</param>
        /// <param name="idrubrica">idrubrica.</param>
        /// <param name="idcontatto">idcontatto.</param>
        /// <param name="codiceufficio">codiceufficio.</param>
        /// <param name="codiceipa">codiceipa.</param>
        /// <param name="pecrubrica">pecrubrica.</param>
        /// <param name="feaenabled">feaenabled.</param>
        /// <param name="feaexpiredate">feaexpiredate.</param>
        /// <param name="nome">nome.</param>
        /// <param name="cognome">cognome.</param>
        /// <param name="pec">pec.</param>
        /// <param name="forceCaseInsensitive">forceCaseInsensitive.</param>
        /// <param name="joinMode">Possible values:  0: INNER  1: LEFT  2: RIGHT .</param>
        /// <param name="nomeTabella">nomeTabella.</param>
        public JoinDmDatiProfilo(string legameTabella = default(string), FieldInt id = default(FieldInt), FieldInt docnumber = default(FieldInt), FieldString campo = default(FieldString), FieldString valore = default(FieldString), FieldString contatti = default(FieldString), FieldString fax = default(FieldString), FieldString tel = default(FieldString), FieldString indirizzo = default(FieldString), FieldString mail = default(FieldString), FieldString localita = default(FieldString), FieldString cap = default(FieldString), FieldString provincia = default(FieldString), FieldString nazione = default(FieldString), FieldString codice = default(FieldString), FieldString contatto = default(FieldString), FieldString mansione = default(FieldString), FieldString telnome = default(FieldString), FieldString faxnome = default(FieldString), FieldString cell = default(FieldString), FieldString abitazione = default(FieldString), FieldString reparto = default(FieldString), FieldString ufficio = default(FieldString), FieldString email = default(FieldString), FieldString riferimento = default(FieldString), FieldString codfis = default(FieldString), FieldString partiva = default(FieldString), FieldString priorita = default(FieldString), FieldInt idrubrica = default(FieldInt), FieldInt idcontatto = default(FieldInt), FieldString codiceufficio = default(FieldString), FieldString codiceipa = default(FieldString), FieldString pecrubrica = default(FieldString), FieldInt feaenabled = default(FieldInt), FieldDateTime feaexpiredate = default(FieldDateTime), FieldString nome = default(FieldString), FieldString cognome = default(FieldString), FieldString pec = default(FieldString), bool? forceCaseInsensitive = default(bool?), int? joinMode = default(int?), string nomeTabella = default(string))
        {
            this.LegameTabella = legameTabella;
            this.Id = id;
            this.Docnumber = docnumber;
            this.Campo = campo;
            this.Valore = valore;
            this.Contatti = contatti;
            this.Fax = fax;
            this.Tel = tel;
            this.Indirizzo = indirizzo;
            this.Mail = mail;
            this.Localita = localita;
            this.Cap = cap;
            this.Provincia = provincia;
            this.Nazione = nazione;
            this.Codice = codice;
            this.Contatto = contatto;
            this.Mansione = mansione;
            this.Telnome = telnome;
            this.Faxnome = faxnome;
            this.Cell = cell;
            this.Abitazione = abitazione;
            this.Reparto = reparto;
            this.Ufficio = ufficio;
            this.Email = email;
            this.Riferimento = riferimento;
            this.Codfis = codfis;
            this.Partiva = partiva;
            this.Priorita = priorita;
            this.Idrubrica = idrubrica;
            this.Idcontatto = idcontatto;
            this.Codiceufficio = codiceufficio;
            this.Codiceipa = codiceipa;
            this.Pecrubrica = pecrubrica;
            this.Feaenabled = feaenabled;
            this.Feaexpiredate = feaexpiredate;
            this.Nome = nome;
            this.Cognome = cognome;
            this.Pec = pec;
            this.ForceCaseInsensitive = forceCaseInsensitive;
            this.JoinMode = joinMode;
            this.NomeTabella = nomeTabella;
        }
        
        /// <summary>
        /// Gets or Sets LegameTabella
        /// </summary>
        [DataMember(Name="legameTabella", EmitDefaultValue=false)]
        public string LegameTabella { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public FieldInt Id { get; set; }

        /// <summary>
        /// Gets or Sets Docnumber
        /// </summary>
        [DataMember(Name="docnumber", EmitDefaultValue=false)]
        public FieldInt Docnumber { get; set; }

        /// <summary>
        /// Gets or Sets Campo
        /// </summary>
        [DataMember(Name="campo", EmitDefaultValue=false)]
        public FieldString Campo { get; set; }

        /// <summary>
        /// Gets or Sets Valore
        /// </summary>
        [DataMember(Name="valore", EmitDefaultValue=false)]
        public FieldString Valore { get; set; }

        /// <summary>
        /// Gets or Sets Contatti
        /// </summary>
        [DataMember(Name="contatti", EmitDefaultValue=false)]
        public FieldString Contatti { get; set; }

        /// <summary>
        /// Gets or Sets Fax
        /// </summary>
        [DataMember(Name="fax", EmitDefaultValue=false)]
        public FieldString Fax { get; set; }

        /// <summary>
        /// Gets or Sets Tel
        /// </summary>
        [DataMember(Name="tel", EmitDefaultValue=false)]
        public FieldString Tel { get; set; }

        /// <summary>
        /// Gets or Sets Indirizzo
        /// </summary>
        [DataMember(Name="indirizzo", EmitDefaultValue=false)]
        public FieldString Indirizzo { get; set; }

        /// <summary>
        /// Gets or Sets Mail
        /// </summary>
        [DataMember(Name="mail", EmitDefaultValue=false)]
        public FieldString Mail { get; set; }

        /// <summary>
        /// Gets or Sets Localita
        /// </summary>
        [DataMember(Name="localita", EmitDefaultValue=false)]
        public FieldString Localita { get; set; }

        /// <summary>
        /// Gets or Sets Cap
        /// </summary>
        [DataMember(Name="cap", EmitDefaultValue=false)]
        public FieldString Cap { get; set; }

        /// <summary>
        /// Gets or Sets Provincia
        /// </summary>
        [DataMember(Name="provincia", EmitDefaultValue=false)]
        public FieldString Provincia { get; set; }

        /// <summary>
        /// Gets or Sets Nazione
        /// </summary>
        [DataMember(Name="nazione", EmitDefaultValue=false)]
        public FieldString Nazione { get; set; }

        /// <summary>
        /// Gets or Sets Codice
        /// </summary>
        [DataMember(Name="codice", EmitDefaultValue=false)]
        public FieldString Codice { get; set; }

        /// <summary>
        /// Gets or Sets Contatto
        /// </summary>
        [DataMember(Name="contatto", EmitDefaultValue=false)]
        public FieldString Contatto { get; set; }

        /// <summary>
        /// Gets or Sets Mansione
        /// </summary>
        [DataMember(Name="mansione", EmitDefaultValue=false)]
        public FieldString Mansione { get; set; }

        /// <summary>
        /// Gets or Sets Telnome
        /// </summary>
        [DataMember(Name="telnome", EmitDefaultValue=false)]
        public FieldString Telnome { get; set; }

        /// <summary>
        /// Gets or Sets Faxnome
        /// </summary>
        [DataMember(Name="faxnome", EmitDefaultValue=false)]
        public FieldString Faxnome { get; set; }

        /// <summary>
        /// Gets or Sets Cell
        /// </summary>
        [DataMember(Name="cell", EmitDefaultValue=false)]
        public FieldString Cell { get; set; }

        /// <summary>
        /// Gets or Sets Abitazione
        /// </summary>
        [DataMember(Name="abitazione", EmitDefaultValue=false)]
        public FieldString Abitazione { get; set; }

        /// <summary>
        /// Gets or Sets Reparto
        /// </summary>
        [DataMember(Name="reparto", EmitDefaultValue=false)]
        public FieldString Reparto { get; set; }

        /// <summary>
        /// Gets or Sets Ufficio
        /// </summary>
        [DataMember(Name="ufficio", EmitDefaultValue=false)]
        public FieldString Ufficio { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public FieldString Email { get; set; }

        /// <summary>
        /// Gets or Sets Riferimento
        /// </summary>
        [DataMember(Name="riferimento", EmitDefaultValue=false)]
        public FieldString Riferimento { get; set; }

        /// <summary>
        /// Gets or Sets Codfis
        /// </summary>
        [DataMember(Name="codfis", EmitDefaultValue=false)]
        public FieldString Codfis { get; set; }

        /// <summary>
        /// Gets or Sets Partiva
        /// </summary>
        [DataMember(Name="partiva", EmitDefaultValue=false)]
        public FieldString Partiva { get; set; }

        /// <summary>
        /// Gets or Sets Priorita
        /// </summary>
        [DataMember(Name="priorita", EmitDefaultValue=false)]
        public FieldString Priorita { get; set; }

        /// <summary>
        /// Gets or Sets Idrubrica
        /// </summary>
        [DataMember(Name="idrubrica", EmitDefaultValue=false)]
        public FieldInt Idrubrica { get; set; }

        /// <summary>
        /// Gets or Sets Idcontatto
        /// </summary>
        [DataMember(Name="idcontatto", EmitDefaultValue=false)]
        public FieldInt Idcontatto { get; set; }

        /// <summary>
        /// Gets or Sets Codiceufficio
        /// </summary>
        [DataMember(Name="codiceufficio", EmitDefaultValue=false)]
        public FieldString Codiceufficio { get; set; }

        /// <summary>
        /// Gets or Sets Codiceipa
        /// </summary>
        [DataMember(Name="codiceipa", EmitDefaultValue=false)]
        public FieldString Codiceipa { get; set; }

        /// <summary>
        /// Gets or Sets Pecrubrica
        /// </summary>
        [DataMember(Name="pecrubrica", EmitDefaultValue=false)]
        public FieldString Pecrubrica { get; set; }

        /// <summary>
        /// Gets or Sets Feaenabled
        /// </summary>
        [DataMember(Name="feaenabled", EmitDefaultValue=false)]
        public FieldInt Feaenabled { get; set; }

        /// <summary>
        /// Gets or Sets Feaexpiredate
        /// </summary>
        [DataMember(Name="feaexpiredate", EmitDefaultValue=false)]
        public FieldDateTime Feaexpiredate { get; set; }

        /// <summary>
        /// Gets or Sets Nome
        /// </summary>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public FieldString Nome { get; set; }

        /// <summary>
        /// Gets or Sets Cognome
        /// </summary>
        [DataMember(Name="cognome", EmitDefaultValue=false)]
        public FieldString Cognome { get; set; }

        /// <summary>
        /// Gets or Sets Pec
        /// </summary>
        [DataMember(Name="pec", EmitDefaultValue=false)]
        public FieldString Pec { get; set; }

        /// <summary>
        /// Gets or Sets ForceCaseInsensitive
        /// </summary>
        [DataMember(Name="forceCaseInsensitive", EmitDefaultValue=false)]
        public bool? ForceCaseInsensitive { get; set; }

        /// <summary>
        /// Possible values:  0: INNER  1: LEFT  2: RIGHT 
        /// </summary>
        /// <value>Possible values:  0: INNER  1: LEFT  2: RIGHT </value>
        [DataMember(Name="joinMode", EmitDefaultValue=false)]
        public int? JoinMode { get; set; }

        /// <summary>
        /// Gets or Sets NomeTabella
        /// </summary>
        [DataMember(Name="nomeTabella", EmitDefaultValue=false)]
        public string NomeTabella { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JoinDmDatiProfilo {\n");
            sb.Append("  LegameTabella: ").Append(LegameTabella).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Docnumber: ").Append(Docnumber).Append("\n");
            sb.Append("  Campo: ").Append(Campo).Append("\n");
            sb.Append("  Valore: ").Append(Valore).Append("\n");
            sb.Append("  Contatti: ").Append(Contatti).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Tel: ").Append(Tel).Append("\n");
            sb.Append("  Indirizzo: ").Append(Indirizzo).Append("\n");
            sb.Append("  Mail: ").Append(Mail).Append("\n");
            sb.Append("  Localita: ").Append(Localita).Append("\n");
            sb.Append("  Cap: ").Append(Cap).Append("\n");
            sb.Append("  Provincia: ").Append(Provincia).Append("\n");
            sb.Append("  Nazione: ").Append(Nazione).Append("\n");
            sb.Append("  Codice: ").Append(Codice).Append("\n");
            sb.Append("  Contatto: ").Append(Contatto).Append("\n");
            sb.Append("  Mansione: ").Append(Mansione).Append("\n");
            sb.Append("  Telnome: ").Append(Telnome).Append("\n");
            sb.Append("  Faxnome: ").Append(Faxnome).Append("\n");
            sb.Append("  Cell: ").Append(Cell).Append("\n");
            sb.Append("  Abitazione: ").Append(Abitazione).Append("\n");
            sb.Append("  Reparto: ").Append(Reparto).Append("\n");
            sb.Append("  Ufficio: ").Append(Ufficio).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Riferimento: ").Append(Riferimento).Append("\n");
            sb.Append("  Codfis: ").Append(Codfis).Append("\n");
            sb.Append("  Partiva: ").Append(Partiva).Append("\n");
            sb.Append("  Priorita: ").Append(Priorita).Append("\n");
            sb.Append("  Idrubrica: ").Append(Idrubrica).Append("\n");
            sb.Append("  Idcontatto: ").Append(Idcontatto).Append("\n");
            sb.Append("  Codiceufficio: ").Append(Codiceufficio).Append("\n");
            sb.Append("  Codiceipa: ").Append(Codiceipa).Append("\n");
            sb.Append("  Pecrubrica: ").Append(Pecrubrica).Append("\n");
            sb.Append("  Feaenabled: ").Append(Feaenabled).Append("\n");
            sb.Append("  Feaexpiredate: ").Append(Feaexpiredate).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Cognome: ").Append(Cognome).Append("\n");
            sb.Append("  Pec: ").Append(Pec).Append("\n");
            sb.Append("  ForceCaseInsensitive: ").Append(ForceCaseInsensitive).Append("\n");
            sb.Append("  JoinMode: ").Append(JoinMode).Append("\n");
            sb.Append("  NomeTabella: ").Append(NomeTabella).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as JoinDmDatiProfilo);
        }

        /// <summary>
        /// Returns true if JoinDmDatiProfilo instances are equal
        /// </summary>
        /// <param name="input">Instance of JoinDmDatiProfilo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JoinDmDatiProfilo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LegameTabella == input.LegameTabella ||
                    (this.LegameTabella != null &&
                    this.LegameTabella.Equals(input.LegameTabella))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Docnumber == input.Docnumber ||
                    (this.Docnumber != null &&
                    this.Docnumber.Equals(input.Docnumber))
                ) && 
                (
                    this.Campo == input.Campo ||
                    (this.Campo != null &&
                    this.Campo.Equals(input.Campo))
                ) && 
                (
                    this.Valore == input.Valore ||
                    (this.Valore != null &&
                    this.Valore.Equals(input.Valore))
                ) && 
                (
                    this.Contatti == input.Contatti ||
                    (this.Contatti != null &&
                    this.Contatti.Equals(input.Contatti))
                ) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && 
                (
                    this.Tel == input.Tel ||
                    (this.Tel != null &&
                    this.Tel.Equals(input.Tel))
                ) && 
                (
                    this.Indirizzo == input.Indirizzo ||
                    (this.Indirizzo != null &&
                    this.Indirizzo.Equals(input.Indirizzo))
                ) && 
                (
                    this.Mail == input.Mail ||
                    (this.Mail != null &&
                    this.Mail.Equals(input.Mail))
                ) && 
                (
                    this.Localita == input.Localita ||
                    (this.Localita != null &&
                    this.Localita.Equals(input.Localita))
                ) && 
                (
                    this.Cap == input.Cap ||
                    (this.Cap != null &&
                    this.Cap.Equals(input.Cap))
                ) && 
                (
                    this.Provincia == input.Provincia ||
                    (this.Provincia != null &&
                    this.Provincia.Equals(input.Provincia))
                ) && 
                (
                    this.Nazione == input.Nazione ||
                    (this.Nazione != null &&
                    this.Nazione.Equals(input.Nazione))
                ) && 
                (
                    this.Codice == input.Codice ||
                    (this.Codice != null &&
                    this.Codice.Equals(input.Codice))
                ) && 
                (
                    this.Contatto == input.Contatto ||
                    (this.Contatto != null &&
                    this.Contatto.Equals(input.Contatto))
                ) && 
                (
                    this.Mansione == input.Mansione ||
                    (this.Mansione != null &&
                    this.Mansione.Equals(input.Mansione))
                ) && 
                (
                    this.Telnome == input.Telnome ||
                    (this.Telnome != null &&
                    this.Telnome.Equals(input.Telnome))
                ) && 
                (
                    this.Faxnome == input.Faxnome ||
                    (this.Faxnome != null &&
                    this.Faxnome.Equals(input.Faxnome))
                ) && 
                (
                    this.Cell == input.Cell ||
                    (this.Cell != null &&
                    this.Cell.Equals(input.Cell))
                ) && 
                (
                    this.Abitazione == input.Abitazione ||
                    (this.Abitazione != null &&
                    this.Abitazione.Equals(input.Abitazione))
                ) && 
                (
                    this.Reparto == input.Reparto ||
                    (this.Reparto != null &&
                    this.Reparto.Equals(input.Reparto))
                ) && 
                (
                    this.Ufficio == input.Ufficio ||
                    (this.Ufficio != null &&
                    this.Ufficio.Equals(input.Ufficio))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Riferimento == input.Riferimento ||
                    (this.Riferimento != null &&
                    this.Riferimento.Equals(input.Riferimento))
                ) && 
                (
                    this.Codfis == input.Codfis ||
                    (this.Codfis != null &&
                    this.Codfis.Equals(input.Codfis))
                ) && 
                (
                    this.Partiva == input.Partiva ||
                    (this.Partiva != null &&
                    this.Partiva.Equals(input.Partiva))
                ) && 
                (
                    this.Priorita == input.Priorita ||
                    (this.Priorita != null &&
                    this.Priorita.Equals(input.Priorita))
                ) && 
                (
                    this.Idrubrica == input.Idrubrica ||
                    (this.Idrubrica != null &&
                    this.Idrubrica.Equals(input.Idrubrica))
                ) && 
                (
                    this.Idcontatto == input.Idcontatto ||
                    (this.Idcontatto != null &&
                    this.Idcontatto.Equals(input.Idcontatto))
                ) && 
                (
                    this.Codiceufficio == input.Codiceufficio ||
                    (this.Codiceufficio != null &&
                    this.Codiceufficio.Equals(input.Codiceufficio))
                ) && 
                (
                    this.Codiceipa == input.Codiceipa ||
                    (this.Codiceipa != null &&
                    this.Codiceipa.Equals(input.Codiceipa))
                ) && 
                (
                    this.Pecrubrica == input.Pecrubrica ||
                    (this.Pecrubrica != null &&
                    this.Pecrubrica.Equals(input.Pecrubrica))
                ) && 
                (
                    this.Feaenabled == input.Feaenabled ||
                    (this.Feaenabled != null &&
                    this.Feaenabled.Equals(input.Feaenabled))
                ) && 
                (
                    this.Feaexpiredate == input.Feaexpiredate ||
                    (this.Feaexpiredate != null &&
                    this.Feaexpiredate.Equals(input.Feaexpiredate))
                ) && 
                (
                    this.Nome == input.Nome ||
                    (this.Nome != null &&
                    this.Nome.Equals(input.Nome))
                ) && 
                (
                    this.Cognome == input.Cognome ||
                    (this.Cognome != null &&
                    this.Cognome.Equals(input.Cognome))
                ) && 
                (
                    this.Pec == input.Pec ||
                    (this.Pec != null &&
                    this.Pec.Equals(input.Pec))
                ) && 
                (
                    this.ForceCaseInsensitive == input.ForceCaseInsensitive ||
                    (this.ForceCaseInsensitive != null &&
                    this.ForceCaseInsensitive.Equals(input.ForceCaseInsensitive))
                ) && 
                (
                    this.JoinMode == input.JoinMode ||
                    (this.JoinMode != null &&
                    this.JoinMode.Equals(input.JoinMode))
                ) && 
                (
                    this.NomeTabella == input.NomeTabella ||
                    (this.NomeTabella != null &&
                    this.NomeTabella.Equals(input.NomeTabella))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.LegameTabella != null)
                    hashCode = hashCode * 59 + this.LegameTabella.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Docnumber != null)
                    hashCode = hashCode * 59 + this.Docnumber.GetHashCode();
                if (this.Campo != null)
                    hashCode = hashCode * 59 + this.Campo.GetHashCode();
                if (this.Valore != null)
                    hashCode = hashCode * 59 + this.Valore.GetHashCode();
                if (this.Contatti != null)
                    hashCode = hashCode * 59 + this.Contatti.GetHashCode();
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.Tel != null)
                    hashCode = hashCode * 59 + this.Tel.GetHashCode();
                if (this.Indirizzo != null)
                    hashCode = hashCode * 59 + this.Indirizzo.GetHashCode();
                if (this.Mail != null)
                    hashCode = hashCode * 59 + this.Mail.GetHashCode();
                if (this.Localita != null)
                    hashCode = hashCode * 59 + this.Localita.GetHashCode();
                if (this.Cap != null)
                    hashCode = hashCode * 59 + this.Cap.GetHashCode();
                if (this.Provincia != null)
                    hashCode = hashCode * 59 + this.Provincia.GetHashCode();
                if (this.Nazione != null)
                    hashCode = hashCode * 59 + this.Nazione.GetHashCode();
                if (this.Codice != null)
                    hashCode = hashCode * 59 + this.Codice.GetHashCode();
                if (this.Contatto != null)
                    hashCode = hashCode * 59 + this.Contatto.GetHashCode();
                if (this.Mansione != null)
                    hashCode = hashCode * 59 + this.Mansione.GetHashCode();
                if (this.Telnome != null)
                    hashCode = hashCode * 59 + this.Telnome.GetHashCode();
                if (this.Faxnome != null)
                    hashCode = hashCode * 59 + this.Faxnome.GetHashCode();
                if (this.Cell != null)
                    hashCode = hashCode * 59 + this.Cell.GetHashCode();
                if (this.Abitazione != null)
                    hashCode = hashCode * 59 + this.Abitazione.GetHashCode();
                if (this.Reparto != null)
                    hashCode = hashCode * 59 + this.Reparto.GetHashCode();
                if (this.Ufficio != null)
                    hashCode = hashCode * 59 + this.Ufficio.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Riferimento != null)
                    hashCode = hashCode * 59 + this.Riferimento.GetHashCode();
                if (this.Codfis != null)
                    hashCode = hashCode * 59 + this.Codfis.GetHashCode();
                if (this.Partiva != null)
                    hashCode = hashCode * 59 + this.Partiva.GetHashCode();
                if (this.Priorita != null)
                    hashCode = hashCode * 59 + this.Priorita.GetHashCode();
                if (this.Idrubrica != null)
                    hashCode = hashCode * 59 + this.Idrubrica.GetHashCode();
                if (this.Idcontatto != null)
                    hashCode = hashCode * 59 + this.Idcontatto.GetHashCode();
                if (this.Codiceufficio != null)
                    hashCode = hashCode * 59 + this.Codiceufficio.GetHashCode();
                if (this.Codiceipa != null)
                    hashCode = hashCode * 59 + this.Codiceipa.GetHashCode();
                if (this.Pecrubrica != null)
                    hashCode = hashCode * 59 + this.Pecrubrica.GetHashCode();
                if (this.Feaenabled != null)
                    hashCode = hashCode * 59 + this.Feaenabled.GetHashCode();
                if (this.Feaexpiredate != null)
                    hashCode = hashCode * 59 + this.Feaexpiredate.GetHashCode();
                if (this.Nome != null)
                    hashCode = hashCode * 59 + this.Nome.GetHashCode();
                if (this.Cognome != null)
                    hashCode = hashCode * 59 + this.Cognome.GetHashCode();
                if (this.Pec != null)
                    hashCode = hashCode * 59 + this.Pec.GetHashCode();
                if (this.ForceCaseInsensitive != null)
                    hashCode = hashCode * 59 + this.ForceCaseInsensitive.GetHashCode();
                if (this.JoinMode != null)
                    hashCode = hashCode * 59 + this.JoinMode.GetHashCode();
                if (this.NomeTabella != null)
                    hashCode = hashCode * 59 + this.NomeTabella.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
