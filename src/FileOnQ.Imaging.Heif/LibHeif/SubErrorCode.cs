namespace FileOnQ.Imaging.Heif
{
	partial class LibHeif
	{
		public enum SubErrorCode
		{
			// no further information available
			Unspecified = 0,

			// --- Invalid_input ---

			// End of data reached unexpectedly.
			EndOfData = 100,

			// Size of box (defined in header) is wrong
			InvalidBoxSize = 101,

			// Mandatory 'ftyp' box is missing
			NoFtypBox = 102,

			NoIdatBox = 103,

			NoMetaBox = 104,
			NoHdlrBox = 105,
			NoHvcCBox = 106,
			NoPitmBox = 107,
			NoIpcoBox = 108,
			NoIpmaBox = 109,
			NoIlocBox = 110,
			NoIinfBox = 111,
			NoIprpBox = 112,
			NoIrefBox = 113,
			NoPictHandler = 114,

			// An item property referenced in the 'ipma' box is not existing in the 'ipco' container.
			IpmaBoxReferencesNonExistingProperty = 115,

			// No properties have been assigned to an item.
			NoPropertiesAssignedToItem = 116,

			// Image has no (compressed) data
			NoItemData = 117,

			// Invalid specification of image grid (tiled image)
			InvalidGridData = 118,

			// Tile-images in a grid image are missing
			MissingGridImages = 119,

			InvalidCleanAperture = 120,

			// Invalid specification of overlay image
			InvalidOverlayData = 121,

			// Overlay image completely outside of visible canvas area
			OverlayImageOutsideOfCanvas = 122,

			AuxiliaryImageTypeUnspecified = 123,

			NoOrInvalidPrimaryItem = 124,

			NoInfeBox = 125,

			UnknownColorProfileType = 126,

			WrongTileImageChromaFormat = 127,

			InvalidFractionalNumber = 128,

			InvalidImageSize = 129,

			InvalidPixiBox = 130,

			NoAv1cBox = 131,

			WrongTileImagePixelDepth = 132,


			// --- Memory_allocation_error ---

			// A security limit preventing unreasonable memory allocations was exceeded by the input file.
			// Please check whether the file is valid. If it is, contact us so that we could increase the
			// security limits further.
			SecurityLimitExceeded = 1000,


			// --- Usage_error ---

			// An item ID was used that is not present in the file.
			NonExistingItemReferenced = 2000, // also used for Invalid_input

			// An API argument was given a NULL pointer, which is not allowed for that function.
			NullPointerArgument = 2001,

			// Image channel referenced that does not exist in the image
			NonExistingImageChannelReferenced = 2002,

			// The version of the passed plugin is not supported.
			UnsupportedPluginVersion = 2003,

			// The version of the passed writer is not supported.
			UnsupportedWriterVersion = 2004,

			// The given (encoder) parameter name does not exist.
			UnsupportedParameter = 2005,

			// The value for the given parameter is not in the valid range.
			InvalidParameterValue = 2006,


			// --- Unsupported_feature ---

			// Image was coded with an unsupported compression method.
			UnsupportedCodec = 3000,

			// Image is specified in an unknown way, e.g. as tiled grid image (which is supported)
			UnsupportedImageType = 3001,

			UnsupportedDataVersion = 3002,

			// The conversion of the source image to the requested chroma / colorspace is not supported.
			UnsupportedColorConversion = 3003,

			UnsupportedItemConstructionMethod = 3004,


			// --- Encoder_plugin_error ---

			UnsupportedBitDepth = 4000,


			// --- Encoding_error ---

			CannotWriteOutputData = 5000,
		}
	}
}
