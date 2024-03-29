﻿using System.Runtime.Serialization;

namespace Soundown.SoundcloudApi.Objects
{
    [DataContract]
    public class TrackObject
    {
        [DataMember(Name = "kind")]
        public string Kind { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }

        [DataMember(Name = "user_id")]
        public int UserId { get; set; }

        [DataMember(Name = "duration")]
        public int Duration { get; set; }

        [DataMember(Name = "commentable")]
        public bool Commentable { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "original_content_size")]
        public int OriginalContentSize { get; set; }

        [DataMember(Name = "last_modified")]
        public string LastModified { get; set; }

        [DataMember(Name = "sharing")]
        public string Sharing { get; set; }

        [DataMember(Name = "tag_list")]
        public string TagList { get; set; }

        [DataMember(Name = "permalink")]
        public string Permalink { get; set; }

        [DataMember(Name = "streamable")]
        public bool Streamable { get; set; }

        [DataMember(Name = "embeddable_by")]
        public string EmbeddableBy { get; set; }

        [DataMember(Name = "downloadable")]
        public bool Downloadable { get; set; }

        [DataMember(Name = "purchase_url")]
        public string PurchaseUrl { get; set; }

        [DataMember(Name = "label_id")]
        public object LabelId { get; set; }

        [DataMember(Name = "purchase_title")]
        public string PurchaseTitle { get; set; }

        [DataMember(Name = "genre")]
        public string Genre { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "label_name")]
        public object LabelName { get; set; }

        [DataMember(Name = "release")]
        public object Release { get; set; }

        [DataMember(Name = "track_type")]
        public object TrackType { get; set; }

        [DataMember(Name = "key_signature")]
        public object KeySignature { get; set; }

        [DataMember(Name = "isrc")]
        public object Isrc { get; set; }

        [DataMember(Name = "video_url")]
        public object VideoUrl { get; set; }

        [DataMember(Name = "bpm")]
        public object Bpm { get; set; }

        [DataMember(Name = "release_year")]
        public object ReleaseYear { get; set; }

        [DataMember(Name = "release_month")]
        public object ReleaseMonth { get; set; }

        [DataMember(Name = "release_day")]
        public object ReleaseDay { get; set; }

        [DataMember(Name = "original_format")]
        public string OriginalFormat { get; set; }

        [DataMember(Name = "license")]
        public string License { get; set; }

        [DataMember(Name = "uri")]
        public string Uri { get; set; }

        [DataMember(Name = "user")]
        public UserObject User { get; set; }

        [DataMember(Name = "permalink_url")]
        public string PermalinkUrl { get; set; }

        [DataMember(Name = "artwork_url")]
        public string ArtworkUrl { get; set; }

        [DataMember(Name = "waveform_url")]
        public string WaveformUrl { get; set; }

        [DataMember(Name = "stream_url")]
        public string StreamUrl { get; set; }

        [DataMember(Name = "playback_count")]
        public int PlaybackCount { get; set; }

        [DataMember(Name = "download_count")]
        public int DownloadCount { get; set; }

        [DataMember(Name = "favoritings_count")]
        public int FavoritingsCount { get; set; }

        [DataMember(Name = "comment_count")]
        public int CommentCount { get; set; }

        [DataMember(Name = "attachments_uri")]
        public string AttachmentsUri { get; set; }

        [DataMember(Name = "policy")]
        public string Policy { get; set; }

    }
}
