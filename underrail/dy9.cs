using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Game.Data;

// Token: 0x02001140 RID: 4416
[eiz("ZMEA")]
[Serializable]
public sealed class dy9 : Aspect<c5x>, ISerializable, bp1
{
	// Token: 0x06005E89 RID: 24201 RVA: 0x00280DA8 File Offset: 0x0027EFA8
	private dy9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<string>("ZMEA:R", ref this.a, A_0);
		di7.ReadList<string>("ZMEA:C", ref this.b, A_0);
		this.c = (MapNodeState)A_0.GetValue("ZMEA:I", typeof(MapNodeState));
		this.d = (MapNodeState)A_0.GetValue("ZMEA:S", typeof(MapNodeState));
		if (ell.a() >= 431)
		{
			this.e = A_0.GetString("ZMEA:CN");
			this.f = A_0.GetString("ZMEA:CD");
		}
		if (ell.a() >= 437)
		{
			this.g = A_0.GetBoolean("ZMEA:SD");
		}
	}

	// Token: 0x06005E8A RID: 24202 RVA: 0x00280E88 File Offset: 0x0027F088
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<string>("ZMEA:R", this.a, info);
		di7.WriteList<string>("ZMEA:C", this.b, info);
		info.AddValue("ZMEA:I", this.c);
		info.AddValue("ZMEA:S", this.d);
		info.AddValue("ZMEA:CN", this.e);
		info.AddValue("ZMEA:CD", this.f);
		info.AddValue("ZMEA:SD", this.g);
	}

	// Token: 0x06005E8B RID: 24203 RVA: 0x00280F20 File Offset: 0x0027F120
	public List<string> b()
	{
		return this.a;
	}

	// Token: 0x06005E8C RID: 24204 RVA: 0x00280F28 File Offset: 0x0027F128
	public void b(List<string> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005E8D RID: 24205 RVA: 0x00280F34 File Offset: 0x0027F134
	public List<string> f()
	{
		return this.b;
	}

	// Token: 0x06005E8E RID: 24206 RVA: 0x00280F3C File Offset: 0x0027F13C
	public void a(List<string> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005E8F RID: 24207 RVA: 0x00280F48 File Offset: 0x0027F148
	public MapNodeState e()
	{
		return this.c;
	}

	// Token: 0x06005E90 RID: 24208 RVA: 0x00280F50 File Offset: 0x0027F150
	public void b(MapNodeState A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005E91 RID: 24209 RVA: 0x00280F5C File Offset: 0x0027F15C
	public MapNodeState a()
	{
		return this.d;
	}

	// Token: 0x06005E92 RID: 24210 RVA: 0x00280F64 File Offset: 0x0027F164
	public void a(MapNodeState A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005E93 RID: 24211 RVA: 0x00280F70 File Offset: 0x0027F170
	public string g()
	{
		return this.e;
	}

	// Token: 0x06005E94 RID: 24212 RVA: 0x00280F78 File Offset: 0x0027F178
	public void b(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005E95 RID: 24213 RVA: 0x00280F84 File Offset: 0x0027F184
	public string d()
	{
		return this.f;
	}

	// Token: 0x06005E96 RID: 24214 RVA: 0x00280F8C File Offset: 0x0027F18C
	public void a(string A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005E97 RID: 24215 RVA: 0x00280F98 File Offset: 0x0027F198
	public bool h()
	{
		return this.g;
	}

	// Token: 0x06005E98 RID: 24216 RVA: 0x00280FA0 File Offset: 0x0027F1A0
	public void a(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06005E99 RID: 24217 RVA: 0x00280FAC File Offset: 0x0027F1AC
	public dy9(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06005E9A RID: 24218 RVA: 0x00280FCC File Offset: 0x0027F1CC
	public void mx()
	{
		e3l e3l = base.a8().GetAspect<e3l>();
		if (e3l == null)
		{
			e3l = new e3l(base.a8());
			base.a8().SetAspect<e3l>(e3l);
		}
		e3l.a.Clear();
		e3l.a.Add("ZoneMapNode");
		foreach (string text in this.a)
		{
			e3l.a.Add(string.Format("LocaleRepresenter_{0}", text.ToLowerInvariant()));
		}
		foreach (string text2 in this.b)
		{
			e3l.a.Add(string.Format("LocaleContainer_{0}", text2.ToLowerInvariant()));
		}
	}

	// Token: 0x06005E9B RID: 24219 RVA: 0x002810DC File Offset: 0x0027F2DC
	public void my()
	{
	}

	// Token: 0x0400258E RID: 9614
	private List<string> a = new List<string>();

	// Token: 0x0400258F RID: 9615
	private List<string> b = new List<string>();

	// Token: 0x04002590 RID: 9616
	private MapNodeState c;

	// Token: 0x04002591 RID: 9617
	private MapNodeState d;

	// Token: 0x04002592 RID: 9618
	private string e;

	// Token: 0x04002593 RID: 9619
	private string f;

	// Token: 0x04002594 RID: 9620
	private bool g;
}
