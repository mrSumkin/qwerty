using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200108A RID: 4234
[eiz("SEAWOJ")]
[Serializable]
public sealed class eun : cze, ISerializable
{
	// Token: 0x0600584C RID: 22604 RVA: 0x002656F4 File Offset: 0x002638F4
	private eun(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("SEAWOJ:I", typeof(Guid?));
		this.c = A_0.GetString("SEAWOJ:A");
		this.a = A_0.GetBoolean("SEAWOJ:L");
	}

	// Token: 0x0600584D RID: 22605 RVA: 0x0026574C File Offset: 0x0026394C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SEAWOJ:I", this.b);
		info.AddValue("SEAWOJ:A", this.c);
		info.AddValue("SEAWOJ:L", this.a);
	}

	// Token: 0x0600584E RID: 22606 RVA: 0x0026579C File Offset: 0x0026399C
	public bool c()
	{
		return this.a;
	}

	// Token: 0x0600584F RID: 22607 RVA: 0x002657A4 File Offset: 0x002639A4
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005850 RID: 22608 RVA: 0x002657B0 File Offset: 0x002639B0
	public string a()
	{
		return this.c;
	}

	// Token: 0x06005851 RID: 22609 RVA: 0x002657B8 File Offset: 0x002639B8
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005852 RID: 22610 RVA: 0x002657C4 File Offset: 0x002639C4
	public Guid? b()
	{
		return this.b;
	}

	// Token: 0x06005853 RID: 22611 RVA: 0x002657CC File Offset: 0x002639CC
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005854 RID: 22612 RVA: 0x002657D8 File Offset: 0x002639D8
	public eun()
	{
	}

	// Token: 0x06005855 RID: 22613 RVA: 0x002657E0 File Offset: 0x002639E0
	public eun(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005856 RID: 22614 RVA: 0x002657F0 File Offset: 0x002639F0
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
			c5x.y = this.a;
		}
	}

	// Token: 0x0400239A RID: 9114
	private new bool a;

	// Token: 0x0400239B RID: 9115
	private Guid? b;

	// Token: 0x0400239C RID: 9116
	private string c;
}
