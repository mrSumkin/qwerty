using System;
using System.Runtime.Serialization;

// Token: 0x020000EC RID: 236
[eiz("BP")]
[Serializable]
public struct dny : ISerializable
{
	// Token: 0x06000540 RID: 1344 RVA: 0x00017488 File Offset: 0x00015688
	public byte b()
	{
		return this.a;
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x00017490 File Offset: 0x00015690
	public void b(byte A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x0001749C File Offset: 0x0001569C
	public byte a()
	{
		return this.b;
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x000174A4 File Offset: 0x000156A4
	public void a(byte A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x000174B0 File Offset: 0x000156B0
	public static bool b(dny A_0, dny A_1)
	{
		return A_0.Equals(A_1);
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x000174C8 File Offset: 0x000156C8
	public static bool a(dny A_0, dny A_1)
	{
		return !A_0.Equals(A_1);
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x000174E0 File Offset: 0x000156E0
	public dny(byte A_0, byte A_1)
	{
		this = new dny(A_0, A_1, true);
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x000174EC File Offset: 0x000156EC
	public dny(byte A_0, byte A_1, bool A_2)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x00017508 File Offset: 0x00015708
	public override int GetHashCode()
	{
		if (!this.c || this.a > this.b)
		{
			return (int)this.a * 1000 + (int)this.b;
		}
		return (int)this.b * 1000 + (int)this.a;
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x00017558 File Offset: 0x00015758
	public override bool Equals(object obj)
	{
		if (obj is dny)
		{
			dny dny = (dny)obj;
			if ((this.a == dny.a && this.b == dny.b) || (!this.c && this.a == dny.b && this.b == dny.a))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x000175CC File Offset: 0x000157CC
	public override string ToString()
	{
		return string.Format("{0} & {1}{2}", this.a, this.b, this.c ? " (p)" : "");
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x00017614 File Offset: 0x00015814
	private dny(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() >= 6)
		{
			this.a = A_0.GetByte("A");
			this.b = A_0.GetByte("B");
			this.c = A_0.GetBoolean("P");
			return;
		}
		this.a = A_0.GetByte("_A");
		this.b = A_0.GetByte("_B");
		this.c = A_0.GetBoolean("_Permutable");
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x00017694 File Offset: 0x00015894
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("A", this.a);
		info.AddValue("B", this.b);
		info.AddValue("P", this.c);
	}

	// Token: 0x04000488 RID: 1160
	private byte a;

	// Token: 0x04000489 RID: 1161
	private byte b;

	// Token: 0x0400048A RID: 1162
	private bool c;
}
