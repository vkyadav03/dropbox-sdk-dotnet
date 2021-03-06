// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The upload session finish batch arg object</para>
    /// </summary>
    public class UploadSessionFinishBatchArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UploadSessionFinishBatchArg> Encoder = new UploadSessionFinishBatchArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UploadSessionFinishBatchArg> Decoder = new UploadSessionFinishBatchArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadSessionFinishBatchArg" />
        /// class.</para>
        /// </summary>
        /// <param name="entries">Commit information for each file in the batch.</param>
        public UploadSessionFinishBatchArg(col.IEnumerable<UploadSessionFinishArg> entries)
        {
            var entriesList = enc.Util.ToList(entries);

            if (entries == null)
            {
                throw new sys.ArgumentNullException("entries");
            }
            if (entriesList.Count > 1000)
            {
                throw new sys.ArgumentOutOfRangeException("entries", "List should at at most 1000 items");
            }

            this.Entries = entriesList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadSessionFinishBatchArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public UploadSessionFinishBatchArg()
        {
        }

        /// <summary>
        /// <para>Commit information for each file in the batch.</para>
        /// </summary>
        public col.IList<UploadSessionFinishArg> Entries { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UploadSessionFinishBatchArg" />.</para>
        /// </summary>
        private class UploadSessionFinishBatchArgEncoder : enc.StructEncoder<UploadSessionFinishBatchArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UploadSessionFinishBatchArg value, enc.IJsonWriter writer)
            {
                WriteListProperty("entries", value.Entries, writer, global::Dropbox.Api.Files.UploadSessionFinishArg.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UploadSessionFinishBatchArg" />.</para>
        /// </summary>
        private class UploadSessionFinishBatchArgDecoder : enc.StructDecoder<UploadSessionFinishBatchArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UploadSessionFinishBatchArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UploadSessionFinishBatchArg Create()
            {
                return new UploadSessionFinishBatchArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UploadSessionFinishBatchArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "entries":
                        value.Entries = ReadList<UploadSessionFinishArg>(reader, global::Dropbox.Api.Files.UploadSessionFinishArg.Decoder);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
