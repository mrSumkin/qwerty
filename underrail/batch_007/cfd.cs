using System;
using System.Runtime.Serialization;

// Token: 0x02001E5E RID: 7774
[eiz("C2")]
[Serializable]
public sealed class cfd : ISerializable
{
	// Token: 0x0600AC47 RID: 44103 RVA: 0x003F9524 File Offset: 0x003F7724
	private cfd(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("C2:C");
		this.b = A_0.GetInt32("C2:D");
		this.c = A_0.GetBoolean("C2:R");
		if (ell.a() >= 548)
		{
			this.d = A_0.GetBoolean("C2:S");
		}
	}

	// Token: 0x0600AC48 RID: 44104 RVA: 0x003F958C File Offset: 0x003F778C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("C2:C", this.a);
		info.AddValue("C2:D", this.b);
		info.AddValue("C2:R", this.c);
		info.AddValue("C2:S", this.d);
	}

	// Token: 0x0600AC49 RID: 44105 RVA: 0x003F95E0 File Offset: 0x003F77E0
	public cfd(string A_0, int A_1, bool A_2 = false, bool A_3 = false)
	{
		czh.a(A_0, "code");
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x04004034 RID: 16436
	public string a;

	// Token: 0x04004035 RID: 16437
	public int b;

	// Token: 0x04004036 RID: 16438
	public bool c;

	// Token: 0x04004037 RID: 16439
	public bool d;
}
