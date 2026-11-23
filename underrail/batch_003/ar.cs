using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020010C8 RID: 4296
[eiz("SCCW")]
[Serializable]
public sealed class ar : cze, ISerializable
{
	// Token: 0x06005A75 RID: 23157 RVA: 0x00270E90 File Offset: 0x0026F090
	private ar(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("SCCW:I", typeof(Guid?));
		this.c = A_0.GetString("SCCW:A");
		this.a = (WeaponKey)A_0.GetValue("SCCW:W", typeof(WeaponKey));
	}

	// Token: 0x06005A76 RID: 23158 RVA: 0x00270EF8 File Offset: 0x0026F0F8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SCCW:I", this.b);
		info.AddValue("SCCW:A", this.c);
		info.AddValue("SCCW:W", this.a);
	}

	// Token: 0x06005A77 RID: 23159 RVA: 0x00270F4C File Offset: 0x0026F14C
	public WeaponKey c()
	{
		return this.a;
	}

	// Token: 0x06005A78 RID: 23160 RVA: 0x00270F54 File Offset: 0x0026F154
	public void a(WeaponKey A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005A79 RID: 23161 RVA: 0x00270F60 File Offset: 0x0026F160
	public string a()
	{
		return this.c;
	}

	// Token: 0x06005A7A RID: 23162 RVA: 0x00270F68 File Offset: 0x0026F168
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005A7B RID: 23163 RVA: 0x00270F74 File Offset: 0x0026F174
	public Guid? b()
	{
		return this.b;
	}

	// Token: 0x06005A7C RID: 23164 RVA: 0x00270F7C File Offset: 0x0026F17C
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005A7D RID: 23165 RVA: 0x00270F88 File Offset: 0x0026F188
	public ar()
	{
	}

	// Token: 0x06005A7E RID: 23166 RVA: 0x00270F94 File Offset: 0x0026F194
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
			c5x c5x2 = A_0 as c5x;
			c5x c5x3 = A_1 as c5x;
			if (c5x2 != null && !c5x2.IsPlayer)
			{
				c5x = c5x2;
			}
			else if (c5x3 != null)
			{
				c5x = c5x3;
			}
		}
		if (c5x != null && c5x.h.b != null)
		{
			c5x.h.b.aa().Offense.a(this.a);
		}
	}

	// Token: 0x0400243B RID: 9275
	private new WeaponKey a;

	// Token: 0x0400243C RID: 9276
	private Guid? b;

	// Token: 0x0400243D RID: 9277
	private string c;
}
