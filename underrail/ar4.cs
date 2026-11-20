using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common.Settings;

// Token: 0x02002049 RID: 8265
public sealed class ar4 : euz, ctv
{
	// Token: 0x0600C3FE RID: 50174 RVA: 0x0043FEB4 File Offset: 0x0043E0B4
	public ar4(esj A_0)
	{
		this.b = new List<Hotkey>();
		foreach (object obj in Enum.GetValues(typeof(Hotkey)))
		{
			Hotkey item = (Hotkey)obj;
			MemberInfo memberInfo = Enumerable.FirstOrDefault<MemberInfo>(typeof(Hotkey).GetMember(item.ToString()));
			if (memberInfo != null && memberInfo.GetCustomAttributes(typeof(cia), true).Length == 0)
			{
				af af = Enumerable.FirstOrDefault<object>(memberInfo.GetCustomAttributes(typeof(af), true)) as af;
				bool flag;
				if (af != null)
				{
					flag = false;
					using (List<string>.Enumerator enumerator2 = af.a().GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (dk2.b(enumerator2.Current))
							{
								flag = true;
								break;
							}
						}
						goto IL_EB;
					}
					goto IL_E8;
				}
				goto IL_E8;
				IL_EB:
				if (flag)
				{
					this.b.Add(item);
					continue;
				}
				continue;
				IL_E8:
				flag = true;
				goto IL_EB;
			}
		}
		this.a(A_0);
	}

	// Token: 0x0600C3FF RID: 50175 RVA: 0x0044000C File Offset: 0x0043E20C
	public euz r5(object A_0)
	{
		Hotkey key = (Hotkey)A_0;
		cbx result;
		this.c.TryGetValue(key, out result);
		return result;
	}

	// Token: 0x0600C400 RID: 50176 RVA: 0x00440030 File Offset: 0x0043E230
	public void a(ls A_0)
	{
		foreach (cbx cbx in this.c.Values)
		{
			cbx.a(A_0);
		}
	}

	// Token: 0x0600C401 RID: 50177 RVA: 0x0044008C File Offset: 0x0043E28C
	private void a(esj A_0)
	{
		this.a();
		wj wj = wj.a();
		this.a = new cj5(this.b, this);
		this.a.Size = A_0;
		this.a.IsPrivateComponent = true;
		if (wj.c())
		{
			this.a.c(25);
			this.a.e(7);
		}
		else
		{
			this.a.c(wj.hr + 5);
			this.a.e((int)((float)this.a.c() / 4.5f));
		}
		this.aox(this.a);
		base.Size = A_0;
	}

	// Token: 0x0600C402 RID: 50178 RVA: 0x00440140 File Offset: 0x0043E340
	private void a()
	{
		this.c = new Dictionary<Hotkey, cbx>();
		foreach (Hotkey hotkey in this.b)
		{
			cbx cbx = new cbx(hotkey);
			cbx.PropagateMouseScrollEvent = true;
			cbx.a(new EventHandler<c1>(this.a));
			cbx.a(new EventHandler<EventArgs>(this.a));
			this.c[hotkey] = cbx;
		}
	}

	// Token: 0x0600C403 RID: 50179 RVA: 0x004401DC File Offset: 0x0043E3DC
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.a.Size = base.Size;
	}

	// Token: 0x0600C404 RID: 50180 RVA: 0x004401F8 File Offset: 0x0043E3F8
	private void a(object A_0, c1 A_1)
	{
		cbx cbx = A_0 as cbx;
		if ((Keys)A_1.a() != Keys.None)
		{
			foreach (cbx cbx2 in this.c.Values)
			{
				if (cbx2 != cbx && cbx2.d() == (Keys)A_1.a())
				{
					bnr.a(new esj(500, 226), new ar4.a(this, cbx, (Keys)A_1.b()), "Conflict", string.Format("К этой кнопке уже привязано действие \"{0}\". Хотите отвязать?", d1o.c(cbx2.c())), "Y", "N", null, null, 0, new cpk[]
					{
						new cpk("Y", "Да", true),
						new cpk("N", "Нет", true)
					}, base.Parent.Parent.Parent, base.Parent.Parent.Parent);
					break;
				}
			}
		}
	}

	// Token: 0x0600C405 RID: 50181 RVA: 0x0044033C File Offset: 0x0043E53C
	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			base.Parent.Parent.Parent.a9();
		}
		catch
		{
		}
	}

	// Token: 0x0400475D RID: 18269
	private new cj5 a;

	// Token: 0x0400475E RID: 18270
	private new List<Hotkey> b;

	// Token: 0x0400475F RID: 18271
	private new Dictionary<Hotkey, cbx> c;

	// Token: 0x0200204A RID: 8266
	private new sealed class a : eyp
	{
		// Token: 0x0600C406 RID: 50182 RVA: 0x0044037C File Offset: 0x0043E57C
		public a(ar4 A_0, cbx A_1, Keys A_2)
		{
			this.a = A_0;
			this.b = A_1;
			this.c = A_2;
		}

		// Token: 0x0600C407 RID: 50183 RVA: 0x0044039C File Offset: 0x0043E59C
		public void g0(string A_0)
		{
			if (A_0 == "Y")
			{
				using (Dictionary<Hotkey, cbx>.ValueCollection.Enumerator enumerator = this.a.c.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						cbx cbx = enumerator.Current;
						if (cbx != this.b && cbx.d() == this.b.d())
						{
							cbx.a(Keys.None);
						}
					}
					return;
				}
			}
			this.b.a(this.c);
		}

		// Token: 0x04004760 RID: 18272
		private ar4 a;

		// Token: 0x04004761 RID: 18273
		private cbx b;

		// Token: 0x04004762 RID: 18274
		private Keys c;
	}
}
