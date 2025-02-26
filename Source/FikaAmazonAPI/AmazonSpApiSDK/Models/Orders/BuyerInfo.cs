﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    /// Buyer information
    /// </summary>
    [DataContract]
    public partial class BuyerInfo : IEquatable<BuyerInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuyerInfo" /> class.
        /// </summary>
        /// <param name="buyerEmail">The anonymized email address of the buyer..</param>
        /// <param name="buyerName">The name of the buyer..</param>
        /// <param name="buyerCounty">The county of the buyer..</param>
        /// <param name="buyerTaxInfo">Tax information about the buyer..</param>
        /// <param name="purchaseOrderNumber">The purchase order (PO) number entered by the buyer at checkout. Returned only for orders where the buyer entered a PO number at checkout..</param>
        public BuyerInfo(string buyerEmail = default(string), string buyerName = default(string), string buyerCounty = default(string), BuyerTaxInfo buyerTaxInfo = default(BuyerTaxInfo), string purchaseOrderNumber = default(string))
        {
            this.BuyerEmail = buyerEmail;
            this.BuyerName = buyerName;
            this.BuyerCounty = buyerCounty;
            this.BuyerTaxInfo = buyerTaxInfo;
            this.PurchaseOrderNumber = purchaseOrderNumber;
        }
        public BuyerInfo()
        {
            this.BuyerEmail = default(string);
            this.BuyerName = default(string);
            this.BuyerCounty = default(string);
            this.BuyerTaxInfo = default(BuyerTaxInfo);
            this.PurchaseOrderNumber = default(string);
        }

        /// <summary>
        /// The anonymized email address of the buyer.
        /// </summary>
        /// <value>The anonymized email address of the buyer.</value>
        [DataMember(Name = "BuyerEmail", EmitDefaultValue = false)]
        public string BuyerEmail { get; set; }

        /// <summary>
        /// The name of the buyer.
        /// </summary>
        /// <value>The name of the buyer.</value>
        [DataMember(Name = "BuyerName", EmitDefaultValue = false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// The county of the buyer.
        /// </summary>
        /// <value>The county of the buyer.</value>
        [DataMember(Name = "BuyerCounty", EmitDefaultValue = false)]
        public string BuyerCounty { get; set; }

        /// <summary>
        /// Tax information about the buyer.
        /// </summary>
        /// <value>Tax information about the buyer.</value>
        [DataMember(Name = "BuyerTaxInfo", EmitDefaultValue = false)]
        public BuyerTaxInfo BuyerTaxInfo { get; set; }

        /// <summary>
        /// The purchase order (PO) number entered by the buyer at checkout. Returned only for orders where the buyer entered a PO number at checkout.
        /// </summary>
        /// <value>The purchase order (PO) number entered by the buyer at checkout. Returned only for orders where the buyer entered a PO number at checkout.</value>
        [DataMember(Name = "PurchaseOrderNumber", EmitDefaultValue = false)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuyerInfo {\n");
            sb.Append("  BuyerEmail: ").Append(BuyerEmail).Append("\n");
            sb.Append("  BuyerName: ").Append(BuyerName).Append("\n");
            sb.Append("  BuyerCounty: ").Append(BuyerCounty).Append("\n");
            sb.Append("  BuyerTaxInfo: ").Append(BuyerTaxInfo).Append("\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
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
            return this.Equals(input as BuyerInfo);
        }

        /// <summary>
        /// Returns true if BuyerInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BuyerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuyerInfo input)
        {
            if (input == null)
                return false;

            return
                (
                    this.BuyerEmail == input.BuyerEmail ||
                    (this.BuyerEmail != null &&
                    this.BuyerEmail.Equals(input.BuyerEmail))
                ) &&
                (
                    this.BuyerName == input.BuyerName ||
                    (this.BuyerName != null &&
                    this.BuyerName.Equals(input.BuyerName))
                ) &&
                (
                    this.BuyerCounty == input.BuyerCounty ||
                    (this.BuyerCounty != null &&
                    this.BuyerCounty.Equals(input.BuyerCounty))
                ) &&
                (
                    this.BuyerTaxInfo == input.BuyerTaxInfo ||
                    (this.BuyerTaxInfo != null &&
                    this.BuyerTaxInfo.Equals(input.BuyerTaxInfo))
                ) &&
                (
                    this.PurchaseOrderNumber == input.PurchaseOrderNumber ||
                    (this.PurchaseOrderNumber != null &&
                    this.PurchaseOrderNumber.Equals(input.PurchaseOrderNumber))
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
                if (this.BuyerEmail != null)
                    hashCode = hashCode * 59 + this.BuyerEmail.GetHashCode();
                if (this.BuyerName != null)
                    hashCode = hashCode * 59 + this.BuyerName.GetHashCode();
                if (this.BuyerCounty != null)
                    hashCode = hashCode * 59 + this.BuyerCounty.GetHashCode();
                if (this.BuyerTaxInfo != null)
                    hashCode = hashCode * 59 + this.BuyerTaxInfo.GetHashCode();
                if (this.PurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderNumber.GetHashCode();
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
