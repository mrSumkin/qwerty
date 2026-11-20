using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x02000510 RID: 1296
[eiz("CTDE")]
[Serializable]
public sealed class d2d : bjs, b2h, ISerializable
{
	// Token: 0x06002166 RID: 8550 RVA: 0x000B25B0 File Offset: 0x000B07B0
	private d2d(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<csk>("CTDE:D", ref this.a, A_0);
			this.b = (cwt)A_0.GetValue("CTDE:AR", typeof(cwt));
			return;
		}
		if (base.GetType() == typeof(d2d))
		{
			this.a = (List<csk>)A_0.GetValue("_Damages", typeof(List<csk>));
			this.b = (cwt)A_0.GetValue("_AttackResult", typeof(cwt));
			return;
		}
		this.a = (List<csk>)A_0.GetValue("CharacterTakesDamageEvent+_Damages", typeof(List<csk>));
		this.b = (cwt)A_0.GetValue("CharacterTakesDamageEvent+_AttackResult", typeof(cwt));
	}

	// Token: 0x06002167 RID: 8551 RVA: 0x000B269C File Offset: 0x000B089C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<csk>("CTDE:D", this.a, info);
		info.AddValue("CTDE:AR", this.b);
	}

	// Token: 0x06002168 RID: 8552 RVA: 0x000B26C8 File Offset: 0x000B08C8
	public cwt c()
	{
		return this.b;
	}

	// Token: 0x06002169 RID: 8553 RVA: 0x000B26D0 File Offset: 0x000B08D0
	public List<csk> d()
	{
		return this.a;
	}

	// Token: 0x0600216A RID: 8554 RVA: 0x000B26D8 File Offset: 0x000B08D8
	public d2d(cwt A_0, List<csk> A_1) : base((A_0 != null) ? A_0.j : null, (A_0 != null) ? A_0.i : null)
	{
		this.a = A_1;
		this.b = A_0;
	}

	// Token: 0x0600216B RID: 8555 RVA: 0x000B2714 File Offset: 0x000B0914
	public override List<string> b()
	{
		if (this.b != null && !this.b.u)
		{
			return new List<string>
			{
				TimelapseTextFeeds.Combat.ToString()
			};
		}
		return new List<string>();
	}

	// Token: 0x0600216C RID: 8556 RVA: 0x000B275C File Offset: 0x000B095C
	public ecs se()
	{
		if (this.b == null)
		{
			return null;
		}
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		string format;
		if (this.b.y != null)
		{
			format = "- " + this.b.y;
		}
		else
		{
			string str = this.b.e ? "наносит крит. цели" : "наносит цели";
			if (this.b.w)
			{
				format = "- {2} получает ";
			}
			else if (!string.IsNullOrEmpty(this.b.k))
			{
				format = "- {0}: {1} " + str + " ({2}) ";
			}
			else
			{
				format = "- {0} " + str + " ({2}) ";
			}
		}
		dl.a.Add(new bph(bvm.a(), string.Format(format, (base.f() != null) ? base.f().a() : base.i(), this.b.k, (base.h() != null) ? base.h().a() : base.i()), null));
		bjs.a(dl, this.a);
		dl.a.Add(new bph(bvm.a(), string.Format("{0}.", (!string.IsNullOrEmpty(this.b.v)) ? (" (" + this.b.v + ")") : ""), null));
		if (!string.IsNullOrEmpty(this.b.aj))
		{
			dl.a.Add(new bph(bvm.a(), " " + this.b.aj, null));
		}
		return ecs;
	}

	// Token: 0x0400144B RID: 5195
	private new List<csk> a;

	// Token: 0x0400144C RID: 5196
	private new cwt b;
}
