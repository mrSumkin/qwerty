using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x020010E3 RID: 4323
[eiz("SPEJ")]
[Serializable]
public sealed class e25 : cze, ISerializable
{
	// Token: 0x06005B33 RID: 23347 RVA: 0x00273918 File Offset: 0x00271B18
	private e25(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("SPEJ:I", typeof(Guid?));
		this.c = A_0.GetString("SPEJ:A");
		this.a = A_0.GetBoolean("SPEJ:E");
		this.d = A_0.GetSingle("SPEJ:R");
	}

	// Token: 0x06005B34 RID: 23348 RVA: 0x00273980 File Offset: 0x00271B80
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SPEJ:I", this.b);
		info.AddValue("SPEJ:A", this.c);
		info.AddValue("SPEJ:E", this.a);
		info.AddValue("SPEJ:R", this.d);
	}

	// Token: 0x06005B35 RID: 23349 RVA: 0x002739E0 File Offset: 0x00271BE0
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06005B36 RID: 23350 RVA: 0x002739E8 File Offset: 0x00271BE8
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005B37 RID: 23351 RVA: 0x002739F4 File Offset: 0x00271BF4
	public string a()
	{
		return this.c;
	}

	// Token: 0x06005B38 RID: 23352 RVA: 0x002739FC File Offset: 0x00271BFC
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005B39 RID: 23353 RVA: 0x00273A08 File Offset: 0x00271C08
	public Guid? d()
	{
		return this.b;
	}

	// Token: 0x06005B3A RID: 23354 RVA: 0x00273A10 File Offset: 0x00271C10
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005B3B RID: 23355 RVA: 0x00273A1C File Offset: 0x00271C1C
	public float c()
	{
		return this.d;
	}

	// Token: 0x06005B3C RID: 23356 RVA: 0x00273A24 File Offset: 0x00271C24
	public void a(float A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005B3D RID: 23357 RVA: 0x00273A30 File Offset: 0x00271C30
	public e25()
	{
	}

	// Token: 0x06005B3E RID: 23358 RVA: 0x00273A3C File Offset: 0x00271C3C
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
			c6g c6g = Enumerable.FirstOrDefault<c6g>(Enumerable.Where<c6g>(Enumerable.OfType<c6g>(c5x.RaysEmitters), new Func<c6g, bool>(e25.a.a.a)));
			if (this.a)
			{
				cnk serviceOrThrow2 = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow2.aqu() != null && serviceOrThrow2.aqu().v() != null)
				{
					if (c6g == null)
					{
						ev2 ev = new ev2();
						ev.Range = serviceOrThrow2.aqu().v().SightRange;
						c6g = new c6g(serviceOrThrow2.aqu().v().c(), ev);
						c6g.be(c5x);
						return;
					}
					if (c6g.Definition.Range != this.d)
					{
						c6g.Definition.Range = this.d;
						c6g.ii(true);
						return;
					}
				}
			}
			else if (c6g != null)
			{
				c6g.ig();
			}
		}
	}

	// Token: 0x0400246F RID: 9327
	private new bool a;

	// Token: 0x04002470 RID: 9328
	private Guid? b;

	// Token: 0x04002471 RID: 9329
	private string c;

	// Token: 0x04002472 RID: 9330
	private float d;

	// Token: 0x020010E4 RID: 4324
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06005B41 RID: 23361 RVA: 0x00273BF0 File Offset: 0x00271DF0
		internal bool a(c6g A_0)
		{
			return A_0.Observer != null && A_0.Observer.c == dm9.a;
		}

		// Token: 0x04002473 RID: 9331
		public static readonly e25.a a = new e25.a();

		// Token: 0x04002474 RID: 9332
		public static Func<c6g, bool> b;
	}
}
