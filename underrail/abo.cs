using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.Space;

// Token: 0x020001FB RID: 507
[eiz("PG2")]
[Serializable]
public struct abo : ISerializable
{
	// Token: 0x06000E73 RID: 3699 RVA: 0x0003A86C File Offset: 0x00038A6C
	private abo(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("PG2:P", typeof(d0z)) as d0z);
		this.b = (e7s)A_0.GetValue("PG2:S", typeof(e7s));
		this.c = (ee4)A_0.GetValue("PG2:PS", typeof(ee4));
		this.d = A_0.GetInt32("PG2:C");
		this.e = (chj)A_0.GetValue("PG2:A", typeof(chj));
		this.f = (aj)A_0.GetValue("PG2:T", typeof(aj));
		if (ell.a() >= 487)
		{
			this.g = (A_0.GetValue("PG2:D", typeof(HorizontalDirection?)) as HorizontalDirection?);
			return;
		}
		this.g = null;
	}

	// Token: 0x06000E74 RID: 3700 RVA: 0x0003A96C File Offset: 0x00038B6C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("PG2:P", this.a);
		info.AddValue("PG2:S", this.b);
		info.AddValue("PG2:PS", this.c);
		info.AddValue("PG2:C", this.d);
		info.AddValue("PG2:A", this.e);
		info.AddValue("PG2:T", this.f);
		info.AddValue("PG2:D", this.g);
	}

	// Token: 0x06000E75 RID: 3701 RVA: 0x0003AA0C File Offset: 0x00038C0C
	public abo(ee4 A_0, chj A_1, aj A_2, int A_3, HorizontalDirection? A_4 = null)
	{
		this.a = null;
		this.b = e7s.a;
		this.c = A_0;
		this.e = A_1;
		this.f = A_2;
		this.d = A_3;
		this.g = A_4;
	}

	// Token: 0x06000E76 RID: 3702 RVA: 0x0003AA44 File Offset: 0x00038C44
	public abo a()
	{
		if (this.a == null)
		{
			throw new InvalidOperationException("This gate does not have a portal associated.");
		}
		if (this.b == e7s.b)
		{
			return this.a.d;
		}
		return this.a.c;
	}

	// Token: 0x04000887 RID: 2183
	public d0z a;

	// Token: 0x04000888 RID: 2184
	public e7s b;

	// Token: 0x04000889 RID: 2185
	public ee4 c;

	// Token: 0x0400088A RID: 2186
	public int d;

	// Token: 0x0400088B RID: 2187
	public chj e;

	// Token: 0x0400088C RID: 2188
	public aj f;

	// Token: 0x0400088D RID: 2189
	public HorizontalDirection? g;
}
