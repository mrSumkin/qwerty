using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020001F6 RID: 502
[eiz("P3")]
[Serializable]
public sealed class d0z : c7t, a9q, ISerializable, ICloneable
{
	// Token: 0x06000E57 RID: 3671 RVA: 0x0003A2F4 File Offset: 0x000384F4
	private d0z(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (Guid)A_0.GetValue("P2:I", typeof(Guid));
		this.b = A_0.GetString("P2:N");
		this.e = (A_0.GetValue("P2:T", typeof(List<object>)) as List<object>);
		this.c = (abo)A_0.GetValue("P2:EN", typeof(abo));
		this.d = (abo)A_0.GetValue("P2:EX", typeof(abo));
	}

	// Token: 0x06000E58 RID: 3672 RVA: 0x0003A3A4 File Offset: 0x000385A4
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("P2:I", this.a);
		info.AddValue("P2:N", this.b);
		info.AddValue("P2:T", this.e);
		info.AddValue("P2:EN", this.c);
		info.AddValue("P2:EX", this.d);
	}

	// Token: 0x06000E59 RID: 3673 RVA: 0x0003A418 File Offset: 0x00038618
	public Guid qe()
	{
		return this.a;
	}

	// Token: 0x06000E5A RID: 3674 RVA: 0x0003A420 File Offset: 0x00038620
	public string y8()
	{
		return this.b;
	}

	// Token: 0x06000E5B RID: 3675 RVA: 0x0003A428 File Offset: 0x00038628
	public d0z(string A_0)
	{
		this.a = Guid.NewGuid();
		this.b = A_0;
	}

	// Token: 0x06000E5C RID: 3676 RVA: 0x0003A450 File Offset: 0x00038650
	public d0z(string A_0, abo A_1, abo A_2, IEnumerable<object> A_3 = null) : this(A_0)
	{
		czh.a(A_1, "entrance");
		czh.a(A_2, "exit");
		this.c = A_1;
		this.c.a = this;
		this.c.b = e7s.b;
		this.d = A_2;
		this.d.a = this;
		this.d.b = e7s.c;
		if (A_3 != null)
		{
			this.e.AddRange(A_3);
		}
	}

	// Token: 0x06000E5D RID: 3677 RVA: 0x0003A4D8 File Offset: 0x000386D8
	public object Clone()
	{
		return this.a();
	}

	// Token: 0x06000E5E RID: 3678 RVA: 0x0003A4E4 File Offset: 0x000386E4
	public d0z a()
	{
		abo a_ = new abo(this.c.c, this.c.e, this.c.f, this.c.d, this.c.g);
		abo a_2 = new abo(this.d.c, this.d.e, this.d.f, this.d.d, this.d.g);
		return new d0z(this.b, a_, a_2, this.e);
	}

	// Token: 0x0400087D RID: 2173
	private Guid a;

	// Token: 0x0400087E RID: 2174
	private string b;

	// Token: 0x0400087F RID: 2175
	public abo c;

	// Token: 0x04000880 RID: 2176
	public abo d;

	// Token: 0x04000881 RID: 2177
	public List<object> e = new List<object>();
}
