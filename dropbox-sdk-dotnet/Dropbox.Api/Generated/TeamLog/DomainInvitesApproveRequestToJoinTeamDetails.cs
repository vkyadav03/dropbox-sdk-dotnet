// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Approved a member's request to join the team.</para>
    /// </summary>
    public class DomainInvitesApproveRequestToJoinTeamDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DomainInvitesApproveRequestToJoinTeamDetails> Encoder = new DomainInvitesApproveRequestToJoinTeamDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DomainInvitesApproveRequestToJoinTeamDetails> Decoder = new DomainInvitesApproveRequestToJoinTeamDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="DomainInvitesApproveRequestToJoinTeamDetails" /> class.</para>
        /// </summary>
        public DomainInvitesApproveRequestToJoinTeamDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DomainInvitesApproveRequestToJoinTeamDetails"
        /// />.</para>
        /// </summary>
        private class DomainInvitesApproveRequestToJoinTeamDetailsEncoder : enc.StructEncoder<DomainInvitesApproveRequestToJoinTeamDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DomainInvitesApproveRequestToJoinTeamDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DomainInvitesApproveRequestToJoinTeamDetails"
        /// />.</para>
        /// </summary>
        private class DomainInvitesApproveRequestToJoinTeamDetailsDecoder : enc.StructDecoder<DomainInvitesApproveRequestToJoinTeamDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="DomainInvitesApproveRequestToJoinTeamDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DomainInvitesApproveRequestToJoinTeamDetails Create()
            {
                return new DomainInvitesApproveRequestToJoinTeamDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DomainInvitesApproveRequestToJoinTeamDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
