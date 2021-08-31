﻿namespace FileOnQ.Imaging.Heif
{
	partial class LibHeif
	{
		public enum ErrorCode
		{
			/// <summary>
			/// Everything ok, no error occurred.
			/// </summary>
			Ok = 0,

			/// <summary>
			/// Input file does not exist.
			/// </summary>
			InputDoesNotExist = 1,

			/// <summary>
			/// Error in input file. Corrupted or invalid content.
			/// </summary>
			InvalidInput = 2,

			/// <summary>
			/// Input file type is not supported.
			/// </summary>
			UnsupportedFileType = 3,

			/// <summary>
			/// Image requires an unsupported decoder feature.
			/// </summary>
			UnsupportedFeature = 4,

			/// <summary>
			/// Library API has been used in an invalid way.
			/// </summary>
			UsageError = 5,

			/// <summary>
			/// Could not allocate enough memory.
			/// </summary>
			MemoryAllocationError = 6,

			/// <summary>
			/// The decoder plugin generated an error
			/// </summary>
			DecoderPluginError = 7,

			/// <summary>
			/// The encoder plugin generated an error
			/// </summary>
			EncoderPluginError = 8,

			/// <summary>
			/// Error during encoding or when writing to the output
			/// </summary>
			EncodingError = 9,

			/// <summary>
			/// Application has asked for a color profile type that does not exist
			/// </summary>
			ColorProfileDoesNotExist = 10
		}
	}
}
