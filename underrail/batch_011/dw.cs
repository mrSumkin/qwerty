using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020011C4 RID: 4548
[eiz("T40")]
[Serializable]
public sealed class dw : s0
{
	// Token: 0x06006175 RID: 24949 RVA: 0x002A6748 File Offset: 0x002A4948
	private dw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("T40:P", typeof(Guid));
		this.b = A_0.GetString("T40:DN");
		this.c = A_0.GetString("T40:DS");
	}

	// Token: 0x06006176 RID: 24950 RVA: 0x002A67A0 File Offset: 0x002A49A0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("T40:P", this.a);
		info.AddValue("T40:DN", this.b);
		info.AddValue("T40:DS", this.c);
	}

	// Token: 0x06006177 RID: 24951 RVA: 0x002A67F0 File Offset: 0x002A49F0
	public Guid c()
	{
		return this.a;
	}

	// Token: 0x06006178 RID: 24952 RVA: 0x002A67F8 File Offset: 0x002A49F8
	public void a(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006179 RID: 24953 RVA: 0x002A6804 File Offset: 0x002A4A04
	public string a()
	{
		return this.b;
	}

	// Token: 0x0600617A RID: 24954 RVA: 0x002A680C File Offset: 0x002A4A0C
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600617B RID: 24955 RVA: 0x002A6818 File Offset: 0x002A4A18
	public string b()
	{
		return this.c;
	}

	// Token: 0x0600617C RID: 24956 RVA: 0x002A6820 File Offset: 0x002A4A20
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600617D RID: 24957 RVA: 0x002A682C File Offset: 0x002A4A2C
	public override string ej()
	{
		return "Безопасность";
	}

	// Token: 0x0600617E RID: 24958 RVA: 0x002A6834 File Offset: 0x002A4A34
	public dw()
	{
	}

	// Token: 0x0600617F RID: 24959 RVA: 0x002A683C File Offset: 0x002A4A3C
	public override string ek(e3q A_0)
	{
		return this.b;
	}

	// Token: 0x06006180 RID: 24960 RVA: 0x002A6848 File Offset: 0x002A4A48
	public override string el(e3q A_0)
	{
		au2 au = A_0 as au2;
		if (au != null && this.a(au.b() as c5x) != null)
		{
			return "Операция успешно завершена.";
		}
		return "#ERROR: Power controls disonnected";
	}

	// Token: 0x06006181 RID: 24961 RVA: 0x002A6884 File Offset: 0x002A4A84
	public override bool em(e3q A_0)
	{
		au2 au = A_0 as au2;
		return au != null && this.a(au.b() as c5x) != null;
	}

	// Token: 0x06006182 RID: 24962 RVA: 0x002A68B4 File Offset: 0x002A4AB4
	public override void en(e3q A_0, c5x A_1)
	{
		A_1.c().a("console", "ConsoleItemPowerToggle", 1f, c9z.a, false, false);
		axh axh = this.a(A_1);
		if (axh != null)
		{
			au2 au = A_0 as au2;
			axh.a((au != null) ? (au.b() as c5x) : null);
		}
	}

	// Token: 0x06006183 RID: 24963 RVA: 0x002A6914 File Offset: 0x002A4B14
	public override string eo(e3q A_0)
	{
		return this.c;
	}

	// Token: 0x06006184 RID: 24964 RVA: 0x002A6920 File Offset: 0x002A4B20
	public override string ep(e3q A_0)
	{
		au2 au = A_0 as au2;
		if (au != null)
		{
			axh axh = this.a(au.b() as c5x);
			if (axh != null)
			{
				return this.b + " - Изменить состояние на " + (axh.i() ? "Off" : "On");
			}
		}
		return "#ERROR: Power controls disonnected";
	}

	// Token: 0x06006185 RID: 24965 RVA: 0x002A6984 File Offset: 0x002A4B84
	private axh a(c5x A_0)
	{
		if (this.d == null && A_0 != null)
		{
			this.d = new EntityAspectReference<axh, axh>(A_0.Area, this.a);
		}
		if (this.d != null)
		{
			return this.d.ao();
		}
		return null;
	}

	// Token: 0x0400296D RID: 10605
	private Guid a;

	// Token: 0x0400296E RID: 10606
	private string b;

	// Token: 0x0400296F RID: 10607
	private string c;

	// Token: 0x04002970 RID: 10608
	[NonSerialized]
	private EntityAspectReference<axh, axh> d;
}
