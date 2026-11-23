using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010CE RID: 4302
[eiz("SEAOJ")]
[Serializable]
public sealed class ch3 : cze, ISerializable
{
	// Token: 0x06005AA4 RID: 23204 RVA: 0x002717A8 File Offset: 0x0026F9A8
	private ch3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("SEAOJ:I", typeof(Guid?));
		this.c = A_0.GetString("SEAOJ:A");
		this.a = (A_0.GetValue("SEAOJ:L", typeof(float?)) as float?);
	}

	// Token: 0x06005AA5 RID: 23205 RVA: 0x00271814 File Offset: 0x0026FA14
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SEAOJ:I", this.b);
		info.AddValue("SEAOJ:A", this.c);
		info.AddValue("SEAOJ:L", this.a);
	}

	// Token: 0x06005AA6 RID: 23206 RVA: 0x00271868 File Offset: 0x0026FA68
	public float? c()
	{
		return this.a;
	}

	// Token: 0x06005AA7 RID: 23207 RVA: 0x00271870 File Offset: 0x0026FA70
	public void a(float? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005AA8 RID: 23208 RVA: 0x0027187C File Offset: 0x0026FA7C
	public string a()
	{
		return this.c;
	}

	// Token: 0x06005AA9 RID: 23209 RVA: 0x00271884 File Offset: 0x0026FA84
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005AAA RID: 23210 RVA: 0x00271890 File Offset: 0x0026FA90
	public Guid? b()
	{
		return this.b;
	}

	// Token: 0x06005AAB RID: 23211 RVA: 0x00271898 File Offset: 0x0026FA98
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005AAC RID: 23212 RVA: 0x002718A4 File Offset: 0x0026FAA4
	public ch3()
	{
	}

	// Token: 0x06005AAD RID: 23213 RVA: 0x002718B0 File Offset: 0x0026FAB0
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.b != null)
		{
			aud aud = null;
			if (this.c != null)
			{
				b4b serviceOrThrow = bpo.GetServiceOrThrow<b4b>();
				if (serviceOrThrow.yn() != null && serviceOrThrow.yn().Zones.Count > 0)
				{
					aud = serviceOrThrow.yn().Zones[0].n(this.c);
				}
			}
			else if (A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x = (new ar7(this.b.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			c5x.ae = this.a;
		}
	}

	// Token: 0x04002447 RID: 9287
	private new float? a;

	// Token: 0x04002448 RID: 9288
	private Guid? b;

	// Token: 0x04002449 RID: 9289
	private string c;
}
