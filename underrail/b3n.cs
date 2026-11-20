using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001944 RID: 6468
[eiz("SEI")]
[elw(typeof(cgd))]
[Serializable]
public sealed class b3n : diz, ISerializable
{
	// Token: 0x06008945 RID: 35141 RVA: 0x00389790 File Offset: 0x00387990
	private b3n(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (Color)A_0.GetValue("SEI:SVC", typeof(Color));
			this.b = (Color)A_0.GetValue("SEI:SVHC", typeof(Color));
			di7.ReadList<z3>("SEI:S", ref this.c, A_0);
			this.d = A_0.GetString("SEI:SVM");
			if (ell.a() >= 196)
			{
				this.e = A_0.GetDouble("SEI:DR");
			}
			else
			{
				this.e = as3.i;
			}
			if (ell.a() >= 199)
			{
				this.f = A_0.GetDouble("SEI:CR");
				return;
			}
			this.f = as3.g;
			return;
		}
		else
		{
			if (base.GetType() == typeof(b3n))
			{
				this.a = (Color)A_0.GetValue("_ShieldVisualColor", typeof(Color));
				this.b = (Color)A_0.GetValue("_ShieldVisualHitColor", typeof(Color));
				this.c = (List<z3>)A_0.GetValue("_Shieldings", typeof(List<z3>));
				this.d = A_0.GetString("_ShieldVisualModel");
				return;
			}
			this.a = (Color)A_0.GetValue("ShieldEmitterItem+_ShieldVisualColor", typeof(Color));
			this.b = (Color)A_0.GetValue("ShieldEmitterItem+_ShieldVisualHitColor", typeof(Color));
			this.c = (List<z3>)A_0.GetValue("ShieldEmitterItem+_Shieldings", typeof(List<z3>));
			this.d = A_0.GetString("ShieldEmitterItem+_ShieldVisualModel");
			return;
		}
	}

	// Token: 0x06008946 RID: 35142 RVA: 0x003899B8 File Offset: 0x00387BB8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SEI:SVC", this.a);
		info.AddValue("SEI:SVHC", this.b);
		di7.WriteList<z3>("SEI:S", this.c, info);
		info.AddValue("SEI:SVM", this.d);
		info.AddValue("SEI:DR", this.e);
		info.AddValue("SEI:CR", this.f);
	}

	// Token: 0x06008947 RID: 35143 RVA: 0x00389A40 File Offset: 0x00387C40
	[OnDeserialized]
	internal new void a(StreamingContext A_0)
	{
		base.i(false);
	}

	// Token: 0x06008948 RID: 35144 RVA: 0x00389A4C File Offset: 0x00387C4C
	public new List<z3> a()
	{
		return this.c;
	}

	// Token: 0x06008949 RID: 35145 RVA: 0x00389A54 File Offset: 0x00387C54
	public double b()
	{
		return this.e;
	}

	// Token: 0x0600894A RID: 35146 RVA: 0x00389A5C File Offset: 0x00387C5C
	public void b(double A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600894B RID: 35147 RVA: 0x00389A68 File Offset: 0x00387C68
	public double e()
	{
		return this.f;
	}

	// Token: 0x0600894C RID: 35148 RVA: 0x00389A70 File Offset: 0x00387C70
	public new void a(double A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600894D RID: 35149 RVA: 0x00389A7C File Offset: 0x00387C7C
	public override string tv()
	{
		return "Энергетический щит";
	}

	// Token: 0x0600894E RID: 35150 RVA: 0x00389A84 File Offset: 0x00387C84
	public string c()
	{
		return this.d;
	}

	// Token: 0x0600894F RID: 35151 RVA: 0x00389A8C File Offset: 0x00387C8C
	public new void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06008950 RID: 35152 RVA: 0x00389A98 File Offset: 0x00387C98
	public Color f()
	{
		return this.a;
	}

	// Token: 0x06008951 RID: 35153 RVA: 0x00389AA0 File Offset: 0x00387CA0
	public new void a(Color A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008952 RID: 35154 RVA: 0x00389AAC File Offset: 0x00387CAC
	public Color d()
	{
		return this.b;
	}

	// Token: 0x06008953 RID: 35155 RVA: 0x00389AB4 File Offset: 0x00387CB4
	public void b(Color A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008954 RID: 35156 RVA: 0x00389AC0 File Offset: 0x00387CC0
	public b3n()
	{
	}

	// Token: 0x06008955 RID: 35157 RVA: 0x00389B20 File Offset: 0x00387D20
	public override bk3 tw()
	{
		b3n b3n = new b3n();
		this.ai7(b3n);
		return b3n;
	}

	// Token: 0x06008956 RID: 35158 RVA: 0x00389B3C File Offset: 0x00387D3C
	protected override void ai7(bk3 A_0)
	{
		base.ai7(A_0);
		b3n b3n = (b3n)A_0;
		b3n.e = this.e;
		b3n.f = this.f;
		b3n.a = this.a;
		b3n.b = this.b;
		b3n.d = this.d;
		b3n.c = new List<z3>();
		if (this.c != null)
		{
			b3n.c.AddRange(this.c);
		}
	}

	// Token: 0x040036A8 RID: 13992
	private new Color a = Color.White * 0.3f;

	// Token: 0x040036A9 RID: 13993
	private Color b = Color.White * 0.7f;

	// Token: 0x040036AA RID: 13994
	private List<z3> c = new List<z3>();

	// Token: 0x040036AB RID: 13995
	private string d;

	// Token: 0x040036AC RID: 13996
	private new double e = as3.i;

	// Token: 0x040036AD RID: 13997
	private double f = as3.g;
}
