using System;
using System.Reflection;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001E13 RID: 7699
[eiz("BA2")]
[Serializable]
public abstract class to : Stat<int>, ISerializable
{
	// Token: 0x0600AA74 RID: 43636 RVA: 0x003F3E0C File Offset: 0x003F200C
	protected to(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("BA2:N");
			return;
		}
		if (base.GetType() == typeof(to))
		{
			this.a = A_0.GetString("_Name");
			return;
		}
		this.a = A_0.GetString("BaseAbility+_Name");
	}

	// Token: 0x0600AA75 RID: 43637 RVA: 0x003F3E7C File Offset: 0x003F207C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BA2:N", this.a);
	}

	// Token: 0x170002A7 RID: 679
	// (get) Token: 0x0600AA76 RID: 43638 RVA: 0x003F3E98 File Offset: 0x003F2098
	public string Name
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x170002A8 RID: 680
	// (get) Token: 0x0600AA77 RID: 43639 RVA: 0x003F3EA0 File Offset: 0x003F20A0
	public float Modifier
	{
		get
		{
			return this.a(0);
		}
	}

	// Token: 0x0600AA78 RID: 43640 RVA: 0x003F3EAC File Offset: 0x003F20AC
	protected to(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600AA79 RID: 43641 RVA: 0x003F3EBC File Offset: 0x003F20BC
	protected to(string A_0, int A_1) : base(A_1)
	{
		this.a = A_0;
	}

	// Token: 0x0600AA7A RID: 43642 RVA: 0x003F3ECC File Offset: 0x003F20CC
	protected to(bn2 A_0, string A_1) : this(A_1)
	{
		base.a(A_0);
	}

	// Token: 0x0600AA7B RID: 43643 RVA: 0x003F3EDC File Offset: 0x003F20DC
	protected to(bn2 A_0, string A_1, int A_2) : this(A_1, A_2)
	{
		base.a(A_0);
	}

	// Token: 0x0600AA7C RID: 43644 RVA: 0x003F3EF0 File Offset: 0x003F20F0
	protected override void lm(object A_0, c1 A_1)
	{
		base.lm(A_0, A_1);
		if (base.e() != null && base.e().re() != null)
		{
			base.e().re().bl();
		}
	}

	// Token: 0x0600AA7D RID: 43645 RVA: 0x003F3F30 File Offset: 0x003F2130
	public void b()
	{
		if (base.g() < aiy.v)
		{
			base.b(aiy.v);
			return;
		}
		if (base.g() > base.f() + aiy.w)
		{
			base.b(base.f() + aiy.w);
		}
	}

	// Token: 0x0600AA7E RID: 43646 RVA: 0x003F3F84 File Offset: 0x003F2184
	public void c()
	{
		base.b(base.f());
	}

	// Token: 0x0600AA7F RID: 43647 RVA: 0x003F3F94 File Offset: 0x003F2194
	public new float a(int A_0 = 0)
	{
		return c2h.d(base.g() + A_0);
	}

	// Token: 0x0600AA80 RID: 43648 RVA: 0x003F3FA4 File Offset: 0x003F21A4
	public static string a(to A_0)
	{
		if (A_0 == null)
		{
			return "Nothing";
		}
		string text = dh9.a("BaseAbilityEnum." + A_0.Name);
		if (string.IsNullOrEmpty(text))
		{
			text = A_0.Name;
		}
		return text;
	}

	// Token: 0x0600AA81 RID: 43649 RVA: 0x003F3FE8 File Offset: 0x003F21E8
	public static string a(Type A_0)
	{
		if (A_0 == null)
		{
			return "Nothing";
		}
		if (!typeof(to).IsAssignableFrom(A_0))
		{
			return null;
		}
		FieldInfo field = A_0.GetField("BaseAbilityName", BindingFlags.Static | BindingFlags.NonPublic);
		if (field == null)
		{
			return null;
		}
		string text = field.GetValue(null) as string;
		string text2 = dh9.a("BaseAbilityEnum." + text);
		if (!string.IsNullOrEmpty(text2))
		{
			text = text2;
		}
		return text;
	}

	// Token: 0x04003FC2 RID: 16322
	private string a;
}
