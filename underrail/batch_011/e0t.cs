using System;
using System.Runtime.Serialization;

// Token: 0x020005EB RID: 1515
[eiz("GCVC")]
[Serializable]
public sealed class e0t : dth, ISerializable
{
	// Token: 0x060027C3 RID: 10179 RVA: 0x000E6BF4 File Offset: 0x000E4DF4
	private e0t(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (Version)A_0.GetValue("GCVC:V", typeof(Version));
		this.b = (ei6)A_0.GetValue("GCVC:C", typeof(ei6));
	}

	// Token: 0x060027C4 RID: 10180 RVA: 0x000E6C48 File Offset: 0x000E4E48
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("GCVC:V", this.a);
		info.AddValue("GCVC:C", this.b);
	}

	// Token: 0x060027C5 RID: 10181 RVA: 0x000E6C74 File Offset: 0x000E4E74
	public Version b()
	{
		return this.a;
	}

	// Token: 0x060027C6 RID: 10182 RVA: 0x000E6C7C File Offset: 0x000E4E7C
	public void a(Version A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060027C7 RID: 10183 RVA: 0x000E6C88 File Offset: 0x000E4E88
	public ei6 a()
	{
		return this.b;
	}

	// Token: 0x060027C8 RID: 10184 RVA: 0x000E6C90 File Offset: 0x000E4E90
	public void a(ei6 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060027C9 RID: 10185 RVA: 0x000E6C9C File Offset: 0x000E4E9C
	public e0t()
	{
	}

	// Token: 0x060027CA RID: 10186 RVA: 0x000E6CA8 File Offset: 0x000E4EA8
	public bool jh(object A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() == null)
		{
			return false;
		}
		Version v = serviceOrThrow.aqu().y();
		switch (this.b)
		{
		case ei6.a:
			return v == this.a;
		case ei6.b:
			return v > this.a;
		case ei6.c:
			return v < this.a;
		case ei6.d:
			return v >= this.a;
		case ei6.e:
			return v <= this.a;
		case ei6.f:
			return v != this.a;
		default:
			return false;
		}
	}

	// Token: 0x060027CB RID: 10187 RVA: 0x000E6D50 File Offset: 0x000E4F50
	public string ji()
	{
		return null;
	}

	// Token: 0x04001640 RID: 5696
	private Version a;

	// Token: 0x04001641 RID: 5697
	private ei6 b;
}
