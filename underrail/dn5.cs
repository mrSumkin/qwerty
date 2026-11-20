using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010AB RID: 4267
[eiz("SGLK")]
[Serializable]
public sealed class dn5 : cze, ISerializable
{
	// Token: 0x06005991 RID: 22929 RVA: 0x0026B180 File Offset: 0x00269380
	private dn5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("SGLK:I", typeof(Guid?));
		this.b = A_0.GetString("SGLK:A");
	}

	// Token: 0x06005992 RID: 22930 RVA: 0x0026B1BC File Offset: 0x002693BC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SGLK:I", this.a);
		info.AddValue("SGLK:A", this.b);
	}

	// Token: 0x06005993 RID: 22931 RVA: 0x0026B1F0 File Offset: 0x002693F0
	public string a()
	{
		return this.b;
	}

	// Token: 0x06005994 RID: 22932 RVA: 0x0026B1F8 File Offset: 0x002693F8
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005995 RID: 22933 RVA: 0x0026B204 File Offset: 0x00269404
	public Guid? b()
	{
		return this.a;
	}

	// Token: 0x06005996 RID: 22934 RVA: 0x0026B20C File Offset: 0x0026940C
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005997 RID: 22935 RVA: 0x0026B218 File Offset: 0x00269418
	public dn5()
	{
	}

	// Token: 0x06005998 RID: 22936 RVA: 0x0026B220 File Offset: 0x00269420
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.a != null)
		{
			aud aud = null;
			if (this.b != null)
			{
				b4b serviceOrThrow = bpo.GetServiceOrThrow<b4b>();
				if (serviceOrThrow.yn() != null && serviceOrThrow.yn().Zones.Count > 0)
				{
					aud = serviceOrThrow.yn().Zones[0].n(this.b);
				}
			}
			else if (A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x = (new ar7(this.a.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			dxv aspect = c5x.GetAspect<dxv>();
			if (aspect != null)
			{
				if (aspect.h())
				{
					aspect.a(false);
					return;
				}
				aspect.a(true);
			}
		}
	}

	// Token: 0x040023FA RID: 9210
	private new Guid? a;

	// Token: 0x040023FB RID: 9211
	private string b;
}
