using ERPNETv1.Model;
using System;
using System.Text;

namespace AppAdo03.Model
{
    [Serializable]
    public class ClientesBaseDAO : DataSet.CategoríasDataTable
    {
        /// <summary>
        /// Propiedad que tiene la cadena de selección base. Esta propiedad
        /// incluye 'SELECT campos FROM tabla' nada más el resto debe ser completado.
        /// Es útil cuando se quiere aumentar métodos con otras condiciones de selección.
        /// </summary>
        protected StringBuilder SelectBase
        {
            get
            {
                StringBuilder sSQL = new StringBuilder();
                sSQL.Append("SELECT ");
                sSQL.Append("TRIM(empresa) empresa, ");
                sSQL.Append("TRIM(fecha) fecha, ");
                sSQL.Append("TRIM(folio) folio, ");
                sSQL.Append("TRIM(rut) rut, ");
                sSQL.Append("TRIM(destino) destino, ");
                sSQL.Append("TRIM(estado) estado, ");
                sSQL.Append("TRIM(tipo) tipo, ");
                sSQL.Append("TRIM(orden_folio) orden_folio, ");
                sSQL.Append("TRIM(orden_fecha) orden_fecha, ");
                sSQL.Append("TRIM(fecha_apr) fecha_apr, ");
                sSQL.Append("TRIM(fecha_rec) fecha_rec, ");
                sSQL.Append("TRIM(fecha_anu) fecha_anu, ");
                sSQL.Append("TRIM(fecha_entrega) fecha_entrega, ");
                sSQL.Append("TRIM(fecha_provee) fecha_provee, ");
                sSQL.Append("TRIM(comentario) comentario, ");
                sSQL.Append("TRIM(tipo_compra) tipo_compra, ");
                sSQL.Append("TRIM(ultima_mod) ultima_mod, ");
                sSQL.Append("TRIM(agente) agente, ");
                sSQL.Append("TRIM(cr_responsable) cr_responsable, ");
                sSQL.Append("TRIM(moneda) moneda, ");
                sSQL.Append("tasa_cambio, ");
                sSQL.Append("TRIM(lugar_entrega) lugar_entrega, ");
                sSQL.Append("TRIM(forma_pago) forma_pago, ");
                sSQL.Append("TRIM(rolreg) rolreg, ");
                sSQL.Append("TRIM(rolapr) rolapr, ");
                sSQL.Append("TRIM(rolcom) rolcom, ");
                sSQL.Append("TRIM(comprador) comprador, ");
                sSQL.Append("impuesto, ");
                sSQL.Append("total, ");
                sSQL.Append("ord_antici, ");
                sSQL.Append("ord_saladelanto, ");
                sSQL.Append("ord_totadelanto, ");
                sSQL.Append("total_pagado, ");
                sSQL.Append("TRIM(num_solicitud) num_solicitud, ");
                sSQL.Append("TRIM(cod_contratista) cod_contratista, ");
                sSQL.Append("TRIM(responsable) responsable, ");
                sSQL.Append("TRIM(resp_retiro) resp_retiro, ");
                sSQL.Append("TRIM(direc_destino) direc_destino, ");
                sSQL.Append("TRIM(comen_destino) comen_destino, ");
                sSQL.Append("TRIM(mot_cancelacion) mot_cancelacion, ");
                sSQL.Append("TRIM(fec_cancelacion) fec_cancelacion, ");
                sSQL.Append("TRIM(cnv_numero) cnv_numero, ");
                sSQL.Append("TRIM(cnv_solicitud) cnv_solicitud, ");
                sSQL.Append("TRIM(emp_externa) emp_externa, ");
                sSQL.Append("TRIM(tipo_origen_det) tipo_origen_det, ");
                sSQL.Append("TRIM(tipo_embarque) tipo_embarque, ");
                sSQL.Append("TRIM(tipo_precio) tipo_precio, ");
                sSQL.Append("TRIM(no_docu) no_docu, ");
                sSQL.Append("TRIM(no_orden) no_orden, ");
                sSQL.Append("TRIM(mot_cancela_det) mot_cancela_det, ");
                sSQL.Append("TRIM(activo_fijo) activo_fijo, ");
                sSQL.Append("TRIM(aud_ing_rol) aud_ing_rol, ");
                sSQL.Append("TO_CHAR(aud_ing_fec, '%d/%m/%Y %H:%M:%S') aud_ing_fec, ");
                sSQL.Append("TRIM(aud_mod_rol) aud_mod_rol, ");
                sSQL.Append("TO_CHAR(aud_mod_fec, '%d/%m/%Y %H:%M:%S') aud_mod_fec, ");
                sSQL.Append("TRIM(aud_anu_rol) aud_anu_rol, ");
                sSQL.Append("TO_CHAR(aud_anu_fec, '%d/%m/%Y %H:%M:%S') aud_anu_fec, ");
                sSQL.Append("TRIM(aud_apr_rol) aud_apr_rol, ");
                sSQL.Append("TO_CHAR(aud_apr_fec, '%d/%m/%Y %H:%M:%S') aud_apr_fec, ");
                sSQL.Append("TRIM(aud_des_rol) aud_des_rol, ");
                sSQL.Append("TO_CHAR(aud_des_fec, '%d/%m/%Y %H:%M:%S') aud_des_fec, ");
                sSQL.Append("TRIM(aud_rec_rol) aud_rec_rol, ");
                sSQL.Append("TO_CHAR(aud_rec_fec, '%d/%m/%Y %H:%M:%S') aud_rec_fec, ");
                sSQL.Append("TRIM(aud_can_rol) aud_can_rol, ");
                sSQL.Append("TO_CHAR(aud_can_fec, '%d/%m/%Y %H:%M:%S') aud_can_fec, ");
                sSQL.Append("TRIM(folio_costeo) folio_costeo, ");
                sSQL.Append("TRIM(ind_costeo) ind_costeo, ");
                sSQL.Append("TRIM(tipo_rut) tipo_rut, ");
                sSQL.Append("TRIM(tipototales) tipototales, ");
                sSQL.Append("TRIM(ind_ebiz) ind_ebiz, ");
                sSQL.Append("TRIM(obs_forma_pago) obs_forma_pago, ");
                sSQL.Append("seguimiento, ");
                sSQL.Append("TRIM(ind_aut_ctrl_stck) ind_aut_ctrl_stck, ");
                sSQL.Append("TRIM(ind_oca) ind_oca, ");
                sSQL.Append("TO_CHAR(fecha_ini_entrega, '%d/%m/%Y %H:%M:%S') fecha_ini_entrega, ");
                sSQL.Append("TRIM(cod_cp_oca) cod_cp_oca, ");
                sSQL.Append("TRIM(origen) origen, ");
                sSQL.Append("TRIM(tipo_variable) tipo_variable, ");
                sSQL.Append("TRIM(emp_factura) emp_factura, ");
                sSQL.Append("TRIM(ind_servicio) ind_servicio, ");
                sSQL.Append("TRIM(per_base_lme) per_base_lme, ");
                sSQL.Append("TRIM(per_calc_lme) per_calc_lme, ");
                sSQL.Append("TRIM(tipo_creacion) tipo_creacion, ");
                sSQL.Append("TRIM(aud_aut_rol) aud_aut_rol, ");
                sSQL.Append("TRIM(aud_aut_emp) aud_aut_emp, ");
                sSQL.Append("TO_CHAR(aud_aut_fec, '%d/%m/%Y %H:%M:%S') aud_aut_fec, ");
                sSQL.Append("TRIM(tipoentrega) tipoentrega, ");
                sSQL.Append("TRIM(lugEntrega_tipo) lugEntrega_tipo, ");
                sSQL.Append("TRIM(lugEntrega_subtipo) lugEntrega_subtipo, ");
                //MS017460_20130806_PFBP <<INICIO>>
                sSQL.Append("TRIM(tipo_retencion) tipo_retencion, retencion ");
                //MS017460_20130806_PFBP <<FIN>>
                sSQL.Append("FROM orden");
                return sSQL;
            }
        }


        /// <summary>
        /// Método que Inserta datos en la tabla principal
        /// desde un dataset seteado previamente
        /// </summary>
        /// <returns>un entero con el numero de registros afectados</returns>
        public int Insertar()
        {
            StringBuilder sSQL = new StringBuilder();

            //sSQL.Append("INSERT INTO detalord(");
            //sSQL.Append("empresa");
            //sSQL.Append(", folio");
            //sSQL.Append(", fecha");
            //sSQL.Append(", sec_desc");
            //sSQL.Append(", grupo");
            //sSQL.Append(", folio_art");
            //sSQL.Append(", cantidad");
            //sSQL.Append(", precio");
            //sSQL.Append(", estado");
            //sSQL.Append(", origen");
            //sSQL.Append(", fecha_entrega");
            //sSQL.Append(", ultima_mod");
            //sSQL.Append(", folio_cotiz");
            //sSQL.Append(", folio_pedido");
            //sSQL.Append(", cantidad_fin");
            //sSQL.Append(", cant_anulada");
            //sSQL.Append(", cant_recibida");
            //sSQL.Append(", marca");
            //sSQL.Append(", precio_orig");
            //sSQL.Append(", marca_ing");
            //sSQL.Append(", precio_costeo");
            //sSQL.Append(", fecha_requerida");
            //sSQL.Append(", fecha_entrega_mod");
            //sSQL.Append(", folio_ent_cus");
            //sSQL.Append(", flag_msg_seguim");
            //sSQL.Append(") VALUES(");
            //sSQL.Append((this.empresaColumn.DefaultValue == DBNull.Value) ? " NULL" : "'" + this.empresaColumn.DefaultValue + "'");
            //sSQL.Append((this.folioColumn.DefaultValue == DBNull.Value) ? ", NULL" : ",'" + this.folioColumn.DefaultValue + "'");
            //sSQL.Append((this.fechaColumn.DefaultValue == DBNull.Value) ? ", NULL" : ",'" + this.fechaColumn.DefaultValue + "'");
            //sSQL.Append((this.sec_descColumn.DefaultValue == DBNull.Value) ? ", NULL" : "," + this.sec_descColumn.DefaultValue + "");
            //sSQL.Append((this.grupoColumn.DefaultValue == DBNull.Value) ? ", NULL" : ",'" + this.grupoColumn.DefaultValue + "'");
            //sSQL.Append((this.folio_artColumn.DefaultValue == DBNull.Value) ? ", NULL" : ",'" + this.folio_artColumn.DefaultValue + "'");
            //sSQL.Append((this.cantidadColumn.DefaultValue == DBNull.Value) ? ", NULL" : "," + this.cantidadColumn.DefaultValue + "");
            //sSQL.Append((this.precioColumn.DefaultValue == DBNull.Value) ? ", NULL" : "," + this.precioColumn.DefaultValue + "");
            //sSQL.Append((this.estadoColumn.DefaultValue == DBNull.Value) ? ", NULL" : ",'" + this.estadoColumn.DefaultValue + "'");
            //sSQL.Append((this.origenColumn.DefaultValue == DBNull.Value) ? ", NULL" : ",'" + this.origenColumn.DefaultValue + "'");
            //sSQL.Append((this.fecha_entregaColumn.DefaultValue == DBNull.Value) ? ", NULL" : ",'" + this.fecha_entregaColumn.DefaultValue + "'");
            //sSQL.Append(",current");
            //sSQL.Append((this.folio_cotizColumn.DefaultValue == DBNull.Value) ? ", NULL" : ",'" + this.folio_cotizColumn.DefaultValue + "'");
            //sSQL.Append((this.folio_pedidoColumn.DefaultValue == DBNull.Value) ? ", NULL" : ",'" + this.folio_pedidoColumn.DefaultValue + "'");
            //sSQL.Append((this.cantidadColumn.DefaultValue == DBNull.Value) ? ", NULL" : "," + this.cantidadColumn.DefaultValue + "");
            //sSQL.Append((this.cant_anuladaColumn.DefaultValue == DBNull.Value) ? ", NULL" : "," + this.cant_anuladaColumn.DefaultValue + "");
            //sSQL.Append((this.cant_recibidaColumn.DefaultValue == DBNull.Value) ? ", NULL" : "," + this.cant_recibidaColumn.DefaultValue + "");
            //sSQL.Append((this.marcaColumn.DefaultValue == DBNull.Value) ? ", NULL" : ",'" + this.marcaColumn.DefaultValue + "'");
            //sSQL.Append((this.precioColumn.DefaultValue == DBNull.Value) ? ", NULL" : "," + this.precioColumn.DefaultValue + "");
            //sSQL.Append((this.marca_ingColumn.DefaultValue == DBNull.Value) ? ", NULL" : ",'" + this.marca_ingColumn.DefaultValue + "'");
            //sSQL.Append((this.precio_costeoColumn.DefaultValue == DBNull.Value) ? ", NULL" : "," + this.precio_costeoColumn.DefaultValue + "");
            //sSQL.Append((this.fecha_requeridaColumn.DefaultValue == DBNull.Value) ? ", NULL" : ",'" + this.fecha_requeridaColumn.DefaultValue + "'");
            //sSQL.Append((this.fecha_entrega_modColumn.DefaultValue == DBNull.Value) ? ", NULL" : ",'" + this.fecha_entrega_modColumn.DefaultValue + "'");
            //sSQL.Append((this.folio_ent_cusColumn.DefaultValue == DBNull.Value) ? ", NULL" : ",'" + this.folio_ent_cusColumn.DefaultValue + "'");
            //sSQL.Append((this.flag_msg_seguimColumn.DefaultValue == DBNull.Value) ? ", 'N'" : ",'" + this.flag_msg_seguimColumn.DefaultValue + "'");
            //sSQL.Append(")");
            //return this._informixHelper.ExecuteNonQuery(CommandType.Text, sSQL.ToString());
            return 0;
        }

        /// <summary>
        /// Método que Elimina datos en la tabla principal
        /// desde un feature seteado previamente (Por lo menos el identificador principal).
        /// </summary>
        /// <returns>un entero con el numero de registros afectados</returns>
        public int Eliminar()
        {
            //StringBuilder sSQL = new StringBuilder();
            //sSQL.Append("delete from detalord where folio = '" + this.folioColumn.DefaultValue + "'");
            //sSQL.Append(" and empresa = '" + this.empresaColumn.DefaultValue + "'");
            return 0;
            //return this._informixHelper.ExecuteNonQuery(CommandType.Text, sSQL.ToString());
        }
    }
}
