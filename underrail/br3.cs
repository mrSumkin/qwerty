using System;
using System.Runtime.Serialization;

// Token: 0x0200118E RID: 4494
[eiz("CMSI")]
[Serializable]
public sealed class br3 : ISerializable
{
	// Token: 0x06005FEE RID: 24558 RVA: 0x0029D27C File Offset: 0x0029B47C
	private br3(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("CMSI:VS");
			this.b = A_0.GetInt32("CMSI:FC");
			return;
		}
		if (base.GetType() == typeof(br3))
		{
			this.a = A_0.GetString("_VariantSuffix");
			this.b = A_0.GetInt32("_FrameCount");
			return;
		}
		this.a = A_0.GetString("CharacterModelStateInfo+_VariantSuffix");
		this.b = A_0.GetInt32("CharacterModelStateInfo+_FrameCount");
	}

	// Token: 0x06005FEF RID: 24559 RVA: 0x0029D31C File Offset: 0x0029B51C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("CMSI:VS", this.a);
		info.AddValue("CMSI:FC", this.b);
	}

	// Token: 0x06005FF0 RID: 24560 RVA: 0x0029D340 File Offset: 0x0029B540
	public string b()
	{
		return this.a;
	}

	// Token: 0x06005FF1 RID: 24561 RVA: 0x0029D348 File Offset: 0x0029B548
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005FF2 RID: 24562 RVA: 0x0029D354 File Offset: 0x0029B554
	public int c()
	{
		return this.b;
	}

	// Token: 0x06005FF3 RID: 24563 RVA: 0x0029D35C File Offset: 0x0029B55C
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005FF4 RID: 24564 RVA: 0x0029D368 File Offset: 0x0029B568
	public br3()
	{
	}

	// Token: 0x06005FF5 RID: 24565 RVA: 0x0029D370 File Offset: 0x0029B570
	public br3(string A_0, int A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06005FF6 RID: 24566 RVA: 0x0029D388 File Offset: 0x0029B588
	public br3 a()
	{
		return new br3(this.a, this.b);
	}

	// Token: 0x04002847 RID: 10311
	private string a;

	// Token: 0x04002848 RID: 10312
	private int b;
}
