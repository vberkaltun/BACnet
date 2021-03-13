﻿namespace System.IO.BACnet
{
	public enum BacnetPtpFrameTypes : byte
	{
		FRAME_TYPE_HEARTBEAT_XOFF = 0,
		FRAME_TYPE_HEARTBEAT_XON = 1,
		FRAME_TYPE_DATA0 = 2,
		FRAME_TYPE_DATA1 = 3,
		FRAME_TYPE_DATA_ACK0_XOFF = 4,
		FRAME_TYPE_DATA_ACK1_XOFF = 5,
		FRAME_TYPE_DATA_ACK0_XON = 6,
		FRAME_TYPE_DATA_ACK1_XON = 7,
		FRAME_TYPE_DATA_NAK0_XOFF = 8,
		FRAME_TYPE_DATA_NAK1_XOFF = 9,
		FRAME_TYPE_DATA_NAK0_XON = 0x0A,
		FRAME_TYPE_DATA_NAK1_XON = 0x0B,
		FRAME_TYPE_CONNECT_REQUEST = 0x0C,
		FRAME_TYPE_CONNECT_RESPONSE = 0x0D,
		FRAME_TYPE_DISCONNECT_REQUEST = 0x0E,
		FRAME_TYPE_DISCONNECT_RESPONSE = 0x0F,
		FRAME_TYPE_TEST_REQUEST = 0x14,
		FRAME_TYPE_TEST_RESPONSE = 0x15,
		FRAME_TYPE_GREETING = 0xFF     //special invention
	}
}