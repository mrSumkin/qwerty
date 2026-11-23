using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.References;

// Token: 0x0200184D RID: 6221
[eiz("AEA1")]
[Serializable]
public sealed class ny : Aspect<b0b>, bp1
{
	// Token: 0x06008491 RID: 33937 RVA: 0x0037255C File Offset: 0x0037075C
	private ny(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadDictionary<ActionReference<cst>, atp>("AEA1:A", ref this.a, A_0);
			if (ell.a() >= 270)
			{
				this.b = (A_0.GetValue("AEA1:PA", typeof(be2)) as be2);
				return;
			}
			KeyValuePair<ActionReference<bgn>, atp>? keyValuePair = (KeyValuePair<ActionReference<bgn>, atp>?)A_0.GetValue("AEA1:PA", typeof(KeyValuePair<ActionReference<bgn>, atp>?));
			if (keyValuePair != null && keyValuePair.Value.Key != null)
			{
				this.b = new be2(keyValuePair.Value.Key, keyValuePair.Value.Value);
				return;
			}
		}
		else
		{
			this.a = new Dictionary<ActionReference<cst>, atp>();
			di7.ReadDictionary<ActionReference<cst>, atp>("_Actions", ref this.a, A_0);
			KeyValuePair<ActionReference<bgn>, atp>? keyValuePair2 = A_0.GetValue("_PrimaryAction", typeof(KeyValuePair<ActionReference<bgn>, atp>?)) as KeyValuePair<ActionReference<bgn>, atp>?;
			if (keyValuePair2 != null && keyValuePair2.Value.Key != null)
			{
				this.b = new be2(keyValuePair2.Value.Key, keyValuePair2.Value.Value);
			}
		}
	}

	// Token: 0x06008492 RID: 33938 RVA: 0x003726B4 File Offset: 0x003708B4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteDictionary<ActionReference<cst>, atp>("AEA1:A", this.a, info);
		info.AddValue("AEA1:PA", this.b);
	}

	// Token: 0x06008493 RID: 33939 RVA: 0x003726E0 File Offset: 0x003708E0
	public bgn a()
	{
		if (this.b == null || this.b.a == null)
		{
			return null;
		}
		return this.b.a.ao();
	}

	// Token: 0x06008494 RID: 33940 RVA: 0x00372710 File Offset: 0x00370910
	public ny(b0b A_0) : base(A_0)
	{
	}

	// Token: 0x06008495 RID: 33941 RVA: 0x00372724 File Offset: 0x00370924
	public void b(cst A_0)
	{
		czh.a(A_0, "action");
		foreach (KeyValuePair<ActionReference<cst>, atp> keyValuePair in this.a)
		{
			if (keyValuePair.Key.ao() == A_0)
			{
				A_0.j();
				break;
			}
		}
	}

	// Token: 0x06008496 RID: 33942 RVA: 0x003727A0 File Offset: 0x003709A0
	public void a(m7 A_0, bool A_1 = true, bool A_2 = false)
	{
		foreach (KeyValuePair<ActionReference<cst>, atp> keyValuePair in Enumerable.ToList<KeyValuePair<ActionReference<cst>, atp>>(this.a))
		{
			cst cst = keyValuePair.Key.ao();
			if (cst != null && (cst.kh() & A_0) != m7.a)
			{
				if (A_1)
				{
					evp evp = cst as evp;
					if (evp != null && evp.sp())
					{
						continue;
					}
				}
				if (A_2 || (cst.kh() & m7.k) != m7.k)
				{
					cst.j();
				}
			}
		}
	}

	// Token: 0x06008497 RID: 33943 RVA: 0x00372858 File Offset: 0x00370A58
	public void a(bool A_0 = true, bool A_1 = false)
	{
		foreach (ActionReference<cst> actionReference in Enumerable.ToList<ActionReference<cst>>(this.a.Keys))
		{
			if (actionReference.ao() != null)
			{
				if (A_0)
				{
					evp evp = actionReference.ao() as evp;
					if (evp != null && evp.sp())
					{
						continue;
					}
				}
				if (A_1 || (actionReference.ao().kh() & m7.k) != m7.k)
				{
					actionReference.ao().j();
					this.a.Remove(actionReference);
				}
			}
			else
			{
				this.a.Remove(actionReference);
			}
		}
		if (this.b != null && this.b.a != null)
		{
			cst cst = this.b.a.ao() as cst;
			if (cst == null || A_1 || (cst.kh() & m7.k) != m7.k)
			{
				this.b = null;
			}
		}
	}

	// Token: 0x06008498 RID: 33944 RVA: 0x0037298C File Offset: 0x00370B8C
	public void a(cst A_0, atp A_1, bool A_2, bool A_3 = false)
	{
		czh.a(A_0, "action");
		if (A_2)
		{
			this.a(A_0.kh(), true, A_3);
		}
		this.b(A_0);
		base.a8().Zone.ActionManager.g9(A_0, A_1);
		if ((A_0.kh() & (m7.b | m7.j)) == m7.b)
		{
			dz6.a(A_0);
		}
		this.a(A_0, A_1);
	}

	// Token: 0x06008499 RID: 33945 RVA: 0x003729F8 File Offset: 0x00370BF8
	public void b(cst A_0, atp A_1)
	{
		this.a(A_0, A_1, false, false);
	}

	// Token: 0x0600849A RID: 33946 RVA: 0x00372A04 File Offset: 0x00370C04
	public void c(cst A_0, atp A_1)
	{
		this.b(A_0);
		this.a(A_0, A_1);
	}

	// Token: 0x0600849B RID: 33947 RVA: 0x00372A18 File Offset: 0x00370C18
	public List<cst> b(m7 A_0)
	{
		List<cst> list = new List<cst>();
		foreach (KeyValuePair<ActionReference<cst>, atp> keyValuePair in this.a)
		{
			if (keyValuePair.Key.ao() != null && (keyValuePair.Key.ao().kh() & A_0) == A_0)
			{
				list.Add(keyValuePair.Key.ao());
			}
		}
		return list;
	}

	// Token: 0x0600849C RID: 33948 RVA: 0x00372AB0 File Offset: 0x00370CB0
	public List<cst> a(m7 A_0)
	{
		List<cst> list = new List<cst>();
		foreach (KeyValuePair<ActionReference<cst>, atp> keyValuePair in this.a)
		{
			if (keyValuePair.Key.ao() != null && (keyValuePair.Key.ao().kh() & A_0) != m7.a)
			{
				list.Add(keyValuePair.Key.ao());
			}
		}
		return list;
	}

	// Token: 0x0600849D RID: 33949 RVA: 0x00372B44 File Offset: 0x00370D44
	private void b(auv A_0)
	{
		if (A_0 != null)
		{
			A_0.l(new EventHandler<EventArgs>(this.a));
			A_0.o(new EventHandler<EventArgs>(this.b));
			A_0.q(new EventHandler<EventArgs>(this.c));
		}
	}

	// Token: 0x0600849E RID: 33950 RVA: 0x00372B84 File Offset: 0x00370D84
	private void a(auv A_0)
	{
		if (A_0 != null)
		{
			A_0.m(new EventHandler<EventArgs>(this.a));
			A_0.p(new EventHandler<EventArgs>(this.b));
			A_0.r(new EventHandler<EventArgs>(this.c));
		}
	}

	// Token: 0x0600849F RID: 33951 RVA: 0x00372BC4 File Offset: 0x00370DC4
	private void a(cst A_0, atp A_1)
	{
		this.a.Add(new ActionReference<cst>(A_0), A_1);
		bgn bgn = A_0 as bgn;
		if (bgn != null && (A_0.kh() & m7.b) == m7.b)
		{
			if (this.b != null && this.b.a != null && this.b.a.ao() != null)
			{
				this.a(this.b.a.ao());
			}
			this.b = new be2(new ActionReference<bgn>(bgn), A_1);
		}
	}

	// Token: 0x060084A0 RID: 33952 RVA: 0x00372C58 File Offset: 0x00370E58
	private bool a(cst A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		KeyValuePair<ActionReference<cst>, atp>? keyValuePair = null;
		foreach (KeyValuePair<ActionReference<cst>, atp> value in this.a)
		{
			if (value.Key.ao() == A_0)
			{
				keyValuePair = new KeyValuePair<ActionReference<cst>, atp>?(value);
				break;
			}
		}
		if (keyValuePair != null)
		{
			atp? atp = null;
			if (A_0.Manager != null)
			{
				atp = A_0.Manager.he(A_0);
			}
			if (atp != null && A_0.State != dc4.d && (A_0.State != dc4.e || atp.GetValueOrDefault() == atp.b))
			{
				atp? atp2 = atp;
				atp atp3 = atp.a;
				if (!(atp2.GetValueOrDefault() == atp3 & atp2 != null))
				{
					return false;
				}
			}
			this.a.Remove(keyValuePair.Value.Key);
			this.a(A_0);
			if (this.b != null && this.b.a != null && this.b.a.ao() == A_0)
			{
				this.b = null;
			}
			return true;
		}
		return false;
	}

	// Token: 0x060084A1 RID: 33953 RVA: 0x00372DB4 File Offset: 0x00370FB4
	[dcc("AEA1:mOAF")]
	private void c(object A_0, EventArgs A_1)
	{
		this.a(A_0 as cst);
	}

	// Token: 0x060084A2 RID: 33954 RVA: 0x00372DC4 File Offset: 0x00370FC4
	[dcc("AEA1:mOAF1")]
	private void b(object A_0, EventArgs A_1)
	{
		this.a(A_0 as cst);
	}

	// Token: 0x060084A3 RID: 33955 RVA: 0x00372DD4 File Offset: 0x00370FD4
	[dcc("AEA1:mOAC")]
	private void a(object A_0, EventArgs A_1)
	{
		this.a(A_0 as cst);
	}

	// Token: 0x060084A4 RID: 33956 RVA: 0x00372DE8 File Offset: 0x00370FE8
	public void mx()
	{
		if (this.a != null)
		{
			foreach (KeyValuePair<ActionReference<cst>, atp> keyValuePair in new Dictionary<ActionReference<cst>, atp>(this.a))
			{
				if (keyValuePair.Key.ao() != null)
				{
					this.a(keyValuePair.Key.ao());
					this.b(keyValuePair.Key.ao());
				}
				else
				{
					this.a.Remove(keyValuePair.Key);
				}
			}
		}
	}

	// Token: 0x060084A5 RID: 33957 RVA: 0x00372E98 File Offset: 0x00371098
	public void my()
	{
		if (this.a != null)
		{
			foreach (KeyValuePair<ActionReference<cst>, atp> keyValuePair in this.a)
			{
				this.a(keyValuePair.Key.ao());
			}
		}
	}

	// Token: 0x040032C6 RID: 12998
	private Dictionary<ActionReference<cst>, atp> a = new Dictionary<ActionReference<cst>, atp>();

	// Token: 0x040032C7 RID: 12999
	private be2 b;
}
