// BinaryCxx.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include "pch.h"
#include <iostream>

#include "Packet.h"

int main()
{
	PacketWriter Writer;

	Writer.WriteBits(1, 1);
	Writer.WriteBits(2, 2);
	Writer.WriteBits(3, 3);
	Writer.WriteBits(4, 4);

	PacketReader Reader(Writer);
	int a = Reader.ReadBits(1);
	int b = Reader.ReadBits(2);
	int c = Reader.ReadBits(3);
	int d = Reader.ReadBits(4);

}