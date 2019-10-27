using System.Collections.Generic;
using System.Text;

namespace netcore.Untity
{
    public static class TemplateGenerator
    {
        public static string GetHTMLString()
        {
            var teacher = Item.GetAllTeacher();
            var sb = new StringBuilder();
            sb.Append(@"<p>
  <br>
</p>
<table cellpadding='0' cellspacing='0' width='100%'>
  <tbody>
    <tr>
      <td>
        <p>รูป</p>
        <p>1&nbsp;นิ้ว</p>
      </td>
    </tr>
  </tbody>
</table>
<table cellpadding='0' cellspacing='0' width='100%'>
  <tbody>
    <tr>
      <td>
        <p>&nbsp;</p>
      </td>
    </tr>
  </tbody>
</table>
<center>
<p>&nbsp; 
  <img src='data:image/jpeg;base64,/9j/4AAQSkZJRgABAQEA3ADcAAD/2wBDAAIBAQEBAQIBAQECAgICAgQDAgICAgUEBAMEBgUGBgYFBgYGBwkIBgcJBwYGCAsICQoKCgoKBggLDAsKDAkKCgr/2wBDAQICAgICAgUDAwUKBwYHCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgr/wAARCADUAKYDASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwD9/KKKKACiiigAoplxcQWsL3NzMkcaKWeR2AVQBkkk9ABX5o/tkf8ABc3xr8Q/i5P+xJ/wR++F4+LnxOkJh1HxbAu/RdB52PJvbCTFCRmRmWFT/E5+Wk3YaTZ94ftFftV/s5/sleB5fiL+0f8AGPQfCGlRg+XNrF+sclw39yGL78z/AOyisfavz88U/wDBwb8Xv2mPElz8PP8Agk1+wD43+Kk8Upifxtr1hJZaNCc/eJHRe4MskRP9015h4g/4Jd+Af2f9f8O/tY/8FofHXi39of4ieKby4Sz0K3mJ0HSbiK3edLVgzoZt5RY0iRQrHgRMqkn7i0T9t7wF8JfAfiT4H/Bj9m0N8Rfhz8Ol8R638LfClubaw01TEZIrRLpreJZC6IwR44mRiu3IJAK1Y3yrzPma3/ZB/wCDj39rYDU/j7+3r4L+CmkXJy3h74faV513Ap6qXjQE8ety/ParK/8ABtleeOz9t/aH/wCCoHxz8W3Eh3XEcWuGCEt/sq7yAD8K9W+O37d/7Smo/sm6F/wUE+BuuaLa/CGTwdp2t+Ixp+gR6lq0cUhH214vPuoEjMBJXBWX/VuxU42nQ/ad8YePvhZ+2D+y38XvBf7QXjO98F/E/wAfXWj+JfD1xq4GmXUN3o9xLpxWBFUJsmVD3LkjduwMCghc7ex4zP8A8GtP7HGnqtxa/tU/Gm0uZHCi5PiyAFmPQf6gHP40kv8Awb3/ALRvwvU3v7Ln/BYT4yeG54xm3g127kvbdMcgbVnTj8K4a5+IHxW+F/8AwU/bw4Pi34o8Qab4f/af8PeFtL07xdr0+pxQ6bqXh29nuAqzswWTzU3q64KknHHFet/Hj9rT9oSHxB+2x8bND+POs6d4O+B2n2OmeAfDdpaWZtLzWv7HiknjmZ4TMyPeTRRbUkQjcxBBIw+RMPaPucJpGp/8HJf7Ken/APCReEfiF8Kv2pvCVrI8ZSweKLUSI22sm9VgJlDAggtMQQR1rvvgD/wcffs8XvjSP4M/t6fBPxn+z140Vgk0PjbS5RpzNkDImKLJGpOTmSMLjneetbXwdXw//wAE+fEXwF+CPgXwb408c/ET4peHbyZ/CVl4z+yaXo9vBZQ3F7dG2kIgKK4SNZpi1wxKqZHJNe+DSf2IP+Cqnwk1rQPiR8JdK8W2Oh65d6D4g0vxDpKm40fVLdjHPAlwudsiMeJIJCOQQ3NKzWw1KL3PdPBvjbwb8RPDdr4x+H/izTdc0i+iEtlqmkX0dzb3CHoySRkqw9wa06/G1v2BP2of2CfHni34s/8ABCP9quXxzoXhLWXt/HvwB8QX32qGOZMl4IWchJXGJBxslDKyiR2BUfYH/BNH/gtT8Bf297+b4L+NtGn+Gvxk0dmg134b+InZJnmjH702ruq+aqkHKECRccrj5i79wceqPtKigEEZB4NFMkKKKKACiiigAooooAKo+JvEvh/wb4evvFnivWrXTtM020kutQv72dY4beFFLPI7sQFUKCST0Aq7JIkUbSyMAqgkknAAr8df21v2hfjP/wAF1/2wJ/8Agmd+xV4rn0z4I+EL2OX4xfEawG6HUgrgNBGw4dAwdI0B/eyKXPyJmk3YaV2Hx2/as/a0/wCC+/xx1b9jn/gn/rV94J/Z70K8Nt8Rviw8TxvrKg8wwEEExuB8kIwzhg0hVDtr7F8NeCf2N/8Agh3+y3N4b+CXwK8Ta7JZaRcalqkfhfQzqOs6stugMt5ezKAEjXIyWIVQcIhxitP4hJ4Z/wCCYX7FF/8ACb9gD4EW/iXU/AGk2lzc+EtImSfUILSaQrLqk1uZElvJCI55NgYNK0ZUMAOPFvgv+0J4v+BfxP0L9or4P+Nde+Nn7On7Q+vi3e0jgnvNb8G+I5lKy+XDNuuJbBzC6vbnLW5XIyudyUdbscpLZDf+ChnjH9nn9rlvAPgbW/i3qraF8d/Dt0fhf4uuPEVzpfhfQhFZee9w72zr9p1FmOUjnIQLGQNpDh8f9nXwL+238SPih8G/2qNG+FFpc/E/4ZW2s/DL4x3GsahJpel+MNIhiP2HWIblY5PtUbShZ0KI4zNKMLwR9DeE/wDgnD+yf+z14C8VWHxf1rT9R+Elj45/4Tfwn4T8XJFFpnge48tmm8mV2B8kzSSyhHOxC+AOMnwL4gf8FlP2gf2u/HF7+z5/wRa/ZyPjMaZL9l1b4xeKIWtfDWk44/dBgvnHAyuSMj7sbjkVzJEqLbPfPgp/wTg8B/CX9j3xd+yl8bvic9z4D8T65qmp3OiaZdyabaaNaX7ySXOlwz7wz2f7yTAfaRvbp8oXJ+IP7bv/AARj+BnhHwp8KfiT+038NL20+Hj258K2l1rq6xPpc1sgjhkR4zKyzRrwHJ3j1rx/Q/8Aggv8Q/2j3Hjr/gqz+3L42+MWsSDzW8I6LfPo/h+3fqIljgClkB43IsR5JAB5Paf8E0P2P/8Aglj8UfhXqOp/D39gXwL4b8SeDvE174a8Y6NqlgNVnsNSs5WjkUXN1vkmjbAdHPJDcgEEVN22VaJz+t/8FN/+DeHx98Tv+FneKPiP8NbvxO0yyN4hvvCkwmaUKVWVpTB8zhSyhz8wUlQQCRXafDzwz/wRp/ah+CviP9mn9n349eDhofjbW7bV9Z0Xwv43SK8vLyBojHJ5c7tIQGghJXaVOwAggkGz4Z0H9mrxz+3x4i/Zpvv2RPhq3gKy8OvYaVqB8G2O648RWgtrq/gz5WSq2mo2WBn70M/px5h/wUP/AOCbv/BJs/Ej4ZfAv/hh7w+3jz4reKvsGj3PhO9n0R9NsoFEt9qcrWhCsIYuEV0YPK6L0yQXdgtE3P2kp9U/Yk+L/wAXf25fFdx448a+Lbb4Xf2F8IoLnwestpaiS8uJVghuLNpI8NNLbqfOWB/Lt8lSDuPLftNfCrXP2Dv+CYXwu/Zt8K+GPDXiv4keKbn+xNMtNTtZpNUvvGGqhpZNRsrqKRHtjBO89xJOQTsiUbkJzUWu/wDBMf8A4Kf/ALAayeK/+CaP7cd7448L2x3TfBz4ybbuC4j6eVBeP/qz2AHk9BliPlru/wBk/wD4LE/An9oH4r6d+zX+3b8EJfgh8ctDuQ2m6D43t1+zz3JUoJtOu5VAy4ZtqnG4HCtIOS7k8nYm+CvhD4T/ALGf7V3wp/Ze1W21rxv8RNS8I3WueLfFOjeKLmNNNuFRxd6jfacnl2cNrPJIdr482SXLFHYFzc/4KIf8Eof2av8AgqX4G039pL9nnx9Y+F/ifaW8d74K+KvhK6AS6ZfmjW5eDmVM8CQHzIz0JAKHzz45fsL/ALVnw58ZeJ/hr4P1jU9Z079or4j20PxQ+P8AA73PiDTPDYgwNLa1gt1js4lCvAt1GywxpMXZUPNW9B/b5Hws+PWm/BL9gL4ZLd/s4fBDwzcaV8TPE4t4INCt7i3AAhtL+by1e4iAPmu0+wlj8jt81NpSFFuJT/4Jif8ABXD4waD8aG/4Jmf8FVtFHhP4z6Qy2/h7xNdAR2fiuLOIsSfdadxyrr8kuCBtf5T+lwIPSvh/9u39h39mj/gt7+xxoPxc+FeuxWPicaYNW+F/j+KB4biznxuWCbGG8pnAV152MN68jng/+CLX/BT34nfELxNrP/BNj9vmKTRfjv8ADctZxTakQj+JrOIH98pwA8yRhWLLxLGyyDPzYhPl0ZduZXR+jlFFFWSFFFFABRRXnP7W37TPw9/Y7/Zy8XftJ/FG9EOj+E9Ie7lTeFa5lyFit0z1eSRkjUerigD4Y/4L4/8ABQH4neF4vDv/AATF/YzuZbj4w/GDZbXktjMUk0fSJmaNnLg/unl2uNxPyRJI5xlTXV/8E6tN/ZT/AGFP2Nbf9nP9jXxr4Y8T+N9SkktdL8TapfJaWnjjxQ0MkkiwTnm4ihCFQUygVBGrF91eKf8ABCv4Fa/8Qrn4m/8ABdP9t+Tb4h8cHUZfDTXkLFdK0KNcyzxKQSFKp5EYGT5UJxnzOe++D3gv/gkL+1drOufsufF/9mXU/hV48vLaOLRPCnxHsJdI1hbaGSRra/0e6lbeXKskh8p/MTYqMoEWBMVfVlSdlZHlfgXwr8ete/aq1vw38SPFVr8E/wBs7RbyW/8ABGvm6kl8N/FnSGAaSzlBwLmAOrbIifOtlkjCjEW1fsvwz8If2R/+Cavw/wDGH7eHx50fSPBGpanH/bPiyx07UpbnSdI1OaCJLqPSrcqqpLcyxAsyJ5krHBJUADpf2Pfhj8Xf2cvg7q+qftt/Fey8Q2/gXVtTPgjxX4lW3bUdN8OICqTXl4mFkleJdzNhW24Dlmzj4Y+FnhTxt/wcT/tiSfHr4qWF/p/7J3wn1t4fBPhqcPEPGOqxHm5lA+9Hhju5+VCsQ5aU05PoiYxvqy58O/hF+1d/wcK+OLf44ftMXOufDT9lTT74TeDPh3YXjQXvjNUbAuLxlPMRK/exgBisfOZT93/tJfs3/Bb4b/8ABOn4jfAf4Y+E7DwZ4WsPhtqkdlbaBELRLTyrOR1lBTB37kVi5O5jkkknNcH+3n8bfGf7H/7Rf7M3ibwPrkll4L8VePx8PfFPheLatk0F/CPsdyqYxG9vNCoBGPkkZcemv/wWf8U+IPDv/BNf4maX4SmMereJrC08N6c45KyalewWWfUgCck+wNJKxW9j0D9iX436r8XP2Ffhx8e/HNyz32rfDyw1LWLhz8zy/ZVMsh92ZWb8a8E/4JRvD4Xb4q/EfxBL9mi13TNG8W6w20/u5tRXUNTlYgclljuYlPUkRgdhXr/7KnwwXWf+CX/gL4TaHMLM6t8EdPsYJc/6l7jSkXd+DSZr4k8V/tu+G/2WPhN8TfBHjyUeHPGHir4Z6N4fi0S5byrjTfEVjatpl1bOC6GNZYGhurS4LJBMiOfNXacLZIS6mh8IPjT4z8NftK+Gv2r/ABlofim3+GGufFnW9WsrS40G0FtptrrNoljYaoLmO6a6mM7NCGt3ixELlzgeUhPtn7dLDwt+378OvjNPjy/B+g6VdSu3SGyufEEGnXr/AEEd9G5/65A9q+F/iJ4o/ZBtvgbe6F8PPiPoZ1/T9EVtDuIvh14Cs7t7yBVeEm8hvlliZpEXdKjBxklTnFfRl7+1FoX/AAUl12Rvg0YtS1Xxj8O9K8GWUGnox+xyT30F7rmqSow8y3s7QRRxRyyqpmmUogbglFWsfRH/AAVO8YXY1X4AfA59ansNL+IPx60Wz1yW2nMbTW1r5l6tuWBBxJNBCCO+MdCa7/8Abq/4J1/swf8ABQv4ZSfDz9oDwNDNdQKW0LxRYRrFqmjzYOJLefG5QCclDlGwMqcDHzn/AMHCsOveH/2d/hb8YPCzldQ8B/GTT9ejdevlWlneXcwHuYrZwPrX2L+0L8a7D4F/s1eM/wBoO6gWeHwp4Mv9c8gtjzjBavMsef8AaKhfxq92TrpY/OL4Dftl/tN/8EefjXpH7CP/AAVH8STeLvhJ4im+w/C3453YaTanQWeolixAUMqkuSyAZy8fKfS37UX7BPwW8c6N4StfF3jbTPDf7M3gi0n1zxB8LvDeleRZa/emVZoJbx4SftFoCzSGAKA7hSSw4Ff9lv4B6R/wUY/4JH+EvDP7b09x4wufil4bbX9avL1gJbG4vZHuYTakD9x9nWREjC9AgBzk5+eP+Cbn7RPxX/4J0/tPT/8ABFn9vfWxq2gX8Mh+BHjvVYv9G1fSzuWPTZC/yk7QUVDna4aLJBjyk2imlJHtvwj/AGub74q/tr+KPFP7KXj1Nf8Agb4B0e30vx5d3t2LTw7Yz7T5smmXBTy5JLNLaIyIp8ordyfMGVRXB/8ABdT/AIJ6eKfjR4J0T/gpF+xbdSaZ8aPhNCmr6df6JhZdd02PEhjJXmSSNNzR5+8jPHzuAGF+2B8FPg58EPHi+C/25vHI039nTwutknwU+Anw40sQr4xvsbmt7m2hla71GdJQcxbVgYPG7NlmWvp/9jb9qf4u+JtU0zwB8eP2S1+DWi+JIZF+EOgXGp273hsbWFS9te2seBZziMeYsa7lCBlJVk+amk0RFuLLP/BKX/gob4M/4KT/ALJOj/HDRxDaeIrIjTPHGiRk50/VI0UyKAefLcMJEJ/hbGSVNfStfjH8T7OX/ggl/wAFltP+LeiK1j+z1+0VM0XiK3RSLXRdTeUl2/uxiKVlmXt5M8q4+TI/ZqGaK4iWeCRXRwCjqchgehB7ikncqStqh1FFFMkK/Ij/AILuePPFf7fX7dHwb/4IxfB3WpY7TU9Uj174oXNq2Rb26qZEV+w8q3SabB6tLCBz1/V/4h+OPD/wx8A658SfFl6ltpXh/SLnUtSuJGwsVvBE0sjE9gFUn8K/KL/g3Z8H6t+058ev2gP+Cw/xniCXfjLxLcaX4WmuuBZ2KHzbggt91EjFrCuDwsLg9ql9io6an0x+35+1l4M/Yj0H4U/sT/AnxF4B0HV9YFnYabofjS48mxXR4l+yxRONpHlvL5aOQfM8tZCqn5nj6n4Z3Nz+3TrMvwT/AOCiP/BO7/hH/FngC4s9ZtNXuZLfVNCuJVm3QXOmX6lZcs0RLRFAygFZOCN3hf7QHxVv/i/D4w+Lnxq/Yl+Ff7THwE1oEW3i/wCEepw3/iHRdMtzK8SXdtcFC8sPmzPut5EdPNYEAjLe/fD3xL8Dv+CcH/BOHW/j9pHjbxrqfgXSvDMvijQrXx9rzX99a200CyWumxu7sQpZkjjTcSPMUFjjNPRIhXbPmD/gtH8afiR+2p+0r4K/4Ihfsra/JaXXi4xan8Ytdsm40fRosTC3cjgZRfMZcjdmGPnzCK+3P2TYvhD8DNW1H9gn4UeA/wDhHrD4WeG9Ik0mLzAw1Gwu0lxdDAB3efBcI5OSXUt3xXx5/wAG7/wE13WPB/jT/gpD+0Ndw3HxR/aB1WfW7WO4kHn2uhCZvK8pD8yxPIcjHy7EgAxjn6D/AOCi/inX/wBkXxF4Z/4KOeEPC95rFh4OhbQvirpGnxb57rwtcyK73Uacb5rS4SKZQSP3clwMjdU+Zb/lOA/4OEfB/jK9/Yk0P4ueANJa91T4cfFPw74ihhQgHbHdiInJ4HzSoMngZ5r0D9sfxb4R/aT/AGYfhP4x0O8Wbw/4p+KXhKW7bHMUct4gMcinlXSYqjI2CrqQQCK9i8KeO/2b/wBur4CXw8KeIdK8ZeDPFGmzWGqQRNuBjkQrJBNGwDwyAHlHCsp7Cvgnxd4J+LHw5+FmsfDPwFeS6peDx9N4dvdLnckXXirQwutaJqiD/lnLqFpZwxXQXh55EcBWLlm2gXY+2/8Agntrbar+w18K5r3CT2HgXT9PvkJ/1U9rAttKpz0KvEwP0r5W+OX7YPwvP7ddz8VPgrp/gzxjaRfDyHRda1fxhpuorYxzR39xJGmm3dpYXXmsQ8vn4TZhLfDkggdp4f8A2h/EvwH8C2998Ffhk/j34efG/U2v/hLPHqlvaLpOq6nHLdXGm6i0rr5Nt5ouJlkQOylpISu4R7uB+EXwB/4KI/Cz4T6B4Aj+L+o6FHpGmx2wtE+NWiQ2cG0Y8q3VvDVxIsK/dQSSyOFA3MxyaTYJWN//AIeEXmMH4PfBM/8Ab74h/wDmdo/Yt/aw+GUH7a3jXUfienhXwtffELRdCsPDLeFrC+TSrqa3luYxbS3N3Z2xa+d7ldqlFDxhFUsymmJ4J/4KGGTYP2rkkP8Azzi+O+jbv18IVzXxt+Ev7fGoeC7PxB4n8Raz4xsPDHiHTPEdzo2o/GPQrnTtQj0+8ivGikji0OxlbIhO3E6DeFLZXIJcLHrH/BZlNN1/4N+HfBGplfJkbxNqt1uGdsNp4T1n5iPTzZoF+riuJ/4LQ/HG6+Fv/BIm/wDhXYI1140+IHg2z0XTdKhOZmRooftc5HaNEypY8F5Y0HzOoNL9pfxT4n/aX+H+lfF7x9op8PJ8XtLt/C3wp8J3Vwkl1YeHLtotQ1zWL8xFkjmbTrZzsRnWJY0UktKwGl8GfhWf2sv2lfBHjf41WovLi78K2vxG1Kxk5j0+wNxs8OaKinhYU2z3s/eS6t42J2oiqXuCVtT61/ZE+GF78Ff2WPh18JNTh8u68OeCtM0+6jx9yWK2jR1/BgRXyj/wVX/ZZ8P/APBUbwb4/wDgF8L9HmsPib8FIdM1nwR43guRG0OtXCS3B01HGCm6GKAs2cK1xE3BTn6B/bm/b++An7B3wvuvGnxQ1w3mty2zf8I54N0v99qes3BZUjjihHIUyOimRsIu4ZOcA2P2DfhH44+GvwLHir4xwxp4++IOqTeLPHqRHKW2o3iofsiE8+XbQrDarn+G3HrT8hLTU+d/+CYv7bPiv/gpZ+wrLrsun+H7P9oT4XC60i+TxXpPnLpmvJBJDDfPECjxrMpYPtIKnzVwduD5L428R/Aj9mv4g6hr8/x31z9pv9s8W7xeHlsPDcmrQeGLpjgwQafDNHa6PbnmMtJMspGWJb5gea/aSvdM/wCCS/8AwW98MftW+EdQhtvhN+0XdL4Y+I9vbSg2+ma5ujPnSBcLE2XhuPm+YLJcHocV7V/wUC/Yh+OfxK+IF78I/gr8W/hR8P8Awl8SfEf/AAmGoeJvEOmO/iCPW7KCMbLMB1inj2RCVnlB8oF8AkqVcewTVtUenf8ABTj9jXUf+Clv/BNjVvhp4q8BS6H46bRodc8PaZfSQyT6XrkERcW/mRO8fzZkgJVypWTOa4T/AIN4P25dS/bA/YJ03wZ8RNRkfx58Lbk+GvFEVySJ5I4s/ZJnB5BMIEbZ/jhc98V2f/BOn4s/sw/Dnx7q37EHwo/ae1n4t+KbTR/+Eo8WeMtV8YRaz9o1CSVbe6h8yM/uSpWJhEAEVJAByr18b+AYz/wSx/4OR9U8AWuLH4dftPaak1hD92KPU5WLKoHA3C9WZFxn5bsDqaUtGOOsbH7E0UUVRJ+fv/Byz+0tdfAH/gmH4g8H6FdtHq/xN1a28K2SRth3imDy3IA64MMLof8AroB3r2//AIJw/sceFPgH/wAE0Ph/+yl4s0JZYJ/AyR+K7UO8Zubm9jMt4CyEMMvM6ggggAAHivhL/guay/tW/wDBXr9kv9gx5PP0qz1iLxH4lsy3ym2e6VpS3bm3spgCem4+vP278VP+ChWoyaz/AGR+yz8O7DxjaabJcfbtV1XVjp1vrLWuTPp+ibkJ1S8CrJnyv3KFQGfJwJ05rl2fKkZPx1/4I7fsteN/EWneOvgd4Nj+HOvSaraJ4qvfCeq3umwa7pCuPtVldW9rKkVyZYsx75FLYY/NXzN/wcI+JdW+N3jX9nz/AIJC/B5ltJfij4wtbjxHb2QCrZ6LbMI0BVfuxr+9l4xgWg9a/TP4XfEvwh8Yvh7pHxP8Baqt7pGt2SXVlcKpUlW6qykAqykFWUgFWUggEV+WX7Jek6l+3x/wcF/tD/tD2+tz2ukfBrwmvg/wdqkEaStp99JGbXz4llDIzB47+UAqRl1BBB5btYUUk7n3j8Z/2M/M8D+C9Y/Zg1m18HePPhXpKWHgDVJYDJaPYrEkcmlXkQP720mSNVP8UbqkqYZBmn+zl+2z8Jf2q7vXv2ZvjH4UXwd8TtMspLbxr8KfE8iNNJbuux57ZiAt9ZSKx2zICCrYYKeK4Xx1/wAFBfiH+wP4r0bwT/wUX8PWy+DtZvV0/Qfjn4YtnGmSTnOyPVbTLPp8zYHzoXhYkkFACF2/+Cgf7KHgL9oTwXov7Vfw48OW2qeNfA1t/aWhatolwIrzVtLK+ZNaW93EQ8cjJ+9t5UYbJkjOdjyKy0Qep8/+K/2bfiP+wD+0Bpun/A7XzYv4jkaD4Ua9cyH7Pq8kKGT/AIQ7Xc8Th41ZbC/P7+Lb5RZgoV9/4TfEs/tV/Bn4wfHT4M+Gb258R6B8ZdA8b2nhTZ/p8Utppmk/arAp/wA9z9mv7Tb3kRhVb4//ABu8R/E/9hj4i+CvH2urrevfD3wvpPxN+G3j2OAQyeIdFtrmO9gv9ijEV3D5D29wqYGXVgFEwUcR4z1Lxd+xh/wVLjtfg98TfDXgXR/2itGl8R/214xsmm0S38u0uLi/3xrcW4E6XKRSxkyKD/as27d0CGZRvfgh+0P8VfFVh4H/AGtPgtovwW8P+NpdR0f4XfFGc3KS61cW1vcTaj9mFzbNHbiWeZoraQuqTPM+FYKiddF8O/2RLFyz/tTfsRQORzj4V2khH/An1kk1Z+Engz9k34ceEovCFn/wUn1bxXdi6mudUvfhj8OtNu59Tu5ZC81zcSW+n3s0sruxJcynsBgAAdVd6d+y9DaNqK6v+1rrkWf3l1a6fr2kxA+vMNog/DikFzk5PDX7JEieUf2vf2KmGOg+EWnkfmNW/rWZq3wk/Yy8R6fc6XdftPfsSXcN3C0VxD/wrK3g8xWGCN0WtAjg9RXTjxR+yEs32WKw/atR88Y+I2pMxP8A1zOpk/8AjtbMS/ASK2F9b/EL9rLw3G6/Jcaj4R1LWYSPXMtjeIfrnHvRYEeM/DDWLjWvGHiv9lG3/aQ8O/Gv4ky/D+w8IfCrxD4KuPMtPDWgajLcx6iZ08yYxT29tAsklxJKzSotpHlXf5/efjV8cL/9n79rzxL8MvgNZWE/jDW/h74R8IeFEvsm00l4W1q7uL65A5+z2lmY53GRu3xJkeYDXEWOp/CL4cfGyw+PXwv/AOCkPh/QvE9rpE+lT2fxf+F8OlDWLaVldYLuSFNMeQRugaNmDFCz44dgfD/hpqWrfH/9kL43/t9jXm1DW/Gnh+18EaJqyjAm1nWXso9Wa35JSKPzrTTosEkR6cRnLOSBufRv7DH7Hnh/9on4iW/7Ynju8vtb8J2upi+8Lav4gXdqfjzUIWZV8QXx6RWaPu+w2MYWFE2zFSxQr7B8Yf25NW+KHxTvv2Pf2DJ7HxJ4/th5fi3xlsFxongOIkgy3bj5bi74Pl2anczcuVUGvO/2ofip4u1g3f7J37PME+leEfBcmm+DYodMuWtpvE3iG5gQ2+jRTRENb2VrbFbi9lQhigMasu2SvY/hd8Pv2Uf+CTv7I11qXinXdE8K+HdIRtS8ZeJ5rRLcahqEuPNnKRLlmdyEjhQHaoSNBhQKaEzw7/gpr/wTA8GeOf8Agkn40+AXw6t7zU/EvhyKfxrput6hIZdQ1fX4Feee6lcfenuFM0fGABIqqAqgDhPgJqsP/BX7/giz8O/G+o+BdG8ceL/B01qdZ8Ka9cNFDrl9pj+VPZSzR/NCLuEK2cEAyqGDKGB+hPgD+0X+0h/wUBg0z4pfC/wY3w0+DFxdJc2eseJ7JZ9d8YWasCVitGJjsLSUZHmyb5WU/IqZD18n/wDBCm4n/ZM/4KJftY/8E1NUcx6fpXipPFHgy2JwqWkrHcFHT5oJ7E4HTY1O/vBvGx9F/sl/swf8FB/DviPw5q/irXvhH8E/h7o96tzJ8HfhR4SF02oJsKiK81GXy8EZBPkx8lQS2PlrwT/g6X+Cus/8M0fDv9tn4fwGLxL8G/H1rdpfQ5Dx2s7rg5H925itmBPTLetfeP7VX7ReofA7RNL8PeA9GstW8a+KLtrbw1pWpXTQWkaooa4vruRFJhtLdDvkfHdVBDOK8B/aO+K3gn/goJ+wz8VP2UvGugx6D471/wCG2q3OkaObtbqw1WSBGe3v9LvgBFqFuJ44X3R4dAwDqholsEdGmfT/AOzN8aNG/aM/Z48EfHnw/IrWfjDwrYavDtI+Xz4EkK+xBYgjsQRRXxL/AMGwHx1n+Ln/AAS10XwVqV20l78PfEmoaBMrklo494uYlOfRLgDHYDHaimndCas7Hin7Pyn9pb/g60+KXjG4PnWPwp+H7W1mG+ZYnjtrOzZc9iZbudwPr6V9L+Ov2KvjNpnxoi8DfDX4YxahpOg642u/C3xtrGveTpfhOG6u47y7sLm0hKzX5hvraO5tocBMMiNKioQ3zX/wb8qPiV/wVA/bT+PFyPNaTxcdNtbgnJKnUbwsPoRBEfwFfr1UxSaKk7M8n8BeAPC/7Fv7M2uS3Pia91SLRbTVvEviLWL8qr3d1IZb28nCLhIVaRpGEaAKgOB6n4Z/4NXvBGp3n7F3jr9pzxRHnWPil8T9Qv7m4YcyrDhCQe485p/yNfU3/BZHx/L8M/8Agl58b/FFvMUlPgG8tIyGxk3AEGPxEhryX/gjh+zh4jl/4I6/Avw74N+MviXwNfnw9c6ut/4djtH85728nuv30d1DKkigSjAwDz19G/iF0Prr9pL4B+B/2n/gf4j+BXxEtFk0vxDp7QO5jDNbygh4Z0B43xyqki/7SCviL/gmR8YPFn7JHjC3/Y/+Nc4t/Buv6xeaZ4LuriQ+T4d8TWzf6d4cLN9yGdf9OsQ33oJig+6oPo+mf8FFfHn7Jn7T0X7H/wDwUGtbSO01TS31LwR8aNJ097fS9WtUdY3TUIBvFhOjvGrOHMJMiE+WGGek/a++A/g+71C8+P8Aa/D5PHXgLxTY2sXxR8K6Xl5poYPmtPENg0J3m8tVwD5REkkO0o2+GNWGGq0PIviP4EsfCHwh8Y+D9WsHm034OeOde0DXo44meRfA/iOAXDOFAy0Vst5BIwA4TTGA+7XNeIrXX/2p/wDgmF8K/wBpD4W3Gl6h8TPgBKLDWJ7jQYdbw1lEdL1jFq+VnkMAN5Ev8TJFg8g17D4R/Zz+PGj+NtO/az/Y7/ao0r4neGdb8MxaZq3hTx3ErDxHp8TO1v8A8TW3UsJ4fMmRXmgkYiRllY4GPJ7a38KfspfFy91D9hPwdqXw/wDir4q1uBvFv7NPiFP+JJrwYHzdWhmjLR2UEcSu5vrdjFiIRPFvKoJGct8R7z43/BPW/C1x+1B+0LoXxS8H+MtDlv8Awt43u/ijqvhHSdRmjVZBp8NrpFu8BnkhbfDHhvNVHC/MuDEdW/Zn+IPg/XPDvxF/4JBeGfDQvtKnWDWviB4+sdPlvLcxkyXFu+oRDUhhcsHFtv4BArkvBXxK+BX9pfEv4d/AT9rX4U6d418GQai9x4817Uw8mm30ga4uLXwppMtwkGn20crFBcl2Mkm7KsBuF/4jeAvD3wavD4S+EXi2y+LS/HnQ2n8WaL8S/CUniPxX4Oup7Iyw3xFpaz3MsTE7PstwgVH2bZERmKgHL6h8Sfhz44/Z3s/gK/w8/ZE1a48u1tfE3i7wv4iiF2uls/KzXK6J9m0+8lgAQzSPGFdndVU4C+jav8Qv2YbK9S18Jf8ABJvwVo2k2jNaXPxF0Xx5ANJ0yaEhHFxeaBBcz2/lkfNJMsYGMswNdR8WbD4r+G/2kND+Pn7LX7OPj7wZban8OLnw18S7rWPg9Jd6drSx+SLGaXTrO5E/mxBrnbJ5bELtjZWU/L55r/gP9hHw1+0z8Pm+CXhHWNcOn/BTU9L8cXHw08J3mm61o2o201mdP1NrCFI7i1nluJJoxlNoEmHzECQDNYt+2G37MjftW/Ab4/QeAtI1HVJLDwP4Ng8Q33jVPGcr3JtrRIY9ZA2R3LYdSiqywnzWCgHHoH7U2h+E/wBir9lv4A/skXt/DqOqw+MIfFviuCzQCTV59N8zU52ijAyZLnWZLGGJAPmacL7V534Q0T4u/An9o21tfEPh7wtY/GzRtKt9Z8JaQLK5t/CfiiTUrea38m6/5Y6TrkrWdwVuIwqyl2hwwya9N+Ath4O+J/xdh/aL8N+CtY+Pvx9tLH7Lq+r+Lo/7D0P4bMW3Npixusi2c0cmcxxJcXLD94zBXDMCPTfgB8M5vCnxt+HHwy8aXsD3nwx+H2p+NPiHfSSjy28S67cFfOdj0ICasQT0R1AwAK+c/wBqi0uv+CtH7Vngr4UrPLL8M7vV7lfC1oCwjvdGsWH9r+JGHeOdjHplk/IImnmXHysPTvin+y+vwh8NeKfi3/wUM/al1bxlP8RNejln+Fnw80w6dB4lukjEdnokQV3u76JEUKIw8UZ3ySSryzV63+y78N9L/Zf8GeJv2xv2wNS0Dwh4h8RWNtHcWDXUaWHgnQLcEWGg27jCsIgxMjIB5szsVBAQU12FfqfTel6Xp2h6Zb6PpFjFbWtpAkNtbwRhEijQBVRQOAAAAAOgFflZ+0+v/DMn/Bzx8E/idAfI034yeAp9D1KReFknSKeJB6FvMjsx9GFet/Dj9tz9rf8A4Ki/HbX/AAF+xRNefCj4OeB9Sax8TfFfW/D6TaxrV6uN9lp9ndJst8AgtJMjlcjKAnbXhn/BfbwhqHwB+Mf7FHxtn8a6xr174P8Ai3JZXGva48Ru7nz57CcGRoY404+zPgBRgE02xxWup96/tl/si+IfjncH4h/DXW7JfEK+Frzw5qOg6+8n9ma7o9y6ST2bvFmSzlZo1KXUQLKQNyuoAHLfsT/s0+KdL8XXnxH+KHww1Pwpp3h+wu9B8A+Edd1mHUbi0S7lW51bUZZ4iyyyXd3na27IhiX5Y97IPqZGV1DocgjIPrS07Jk3dj8hP+Dby4n+CX7Y/wC2H+xpdSsI/DnxCN3p8RONqw3l5ayOAezL9nwfQD1orjfhN4zi/Zn/AODjb9p2zFyLO08ReEY9SQg4DvI+lyMfqXllP50VF7FS3Oz/AODU3Gtx/tMePLggzah8T4/Mf1z9ok/m5r7d1X/gpPPaa5c63of7HPxZ1n4c2NzJFd/E3TdJtWsmjjYq93DbG4F1PaqQxMyRHcqlkVlwT8Q/8GmUca/DX9ofQblctH8TYlkUnkjyZVP8jX114h/4KH/sTeDPgXc/BrwF+3N4H0vxBZ6bPpunXt5ps2ovYbC0YEtnAys8ka4Vl3KC65IAO2qjsE/iOU/4OK/FdqP+CNnxM13RrxZrbUodHW3nibKyRTajagMD3BDD8DUX7O/xD/ap/ZF/4J/fCX4yeE/CmjePPhfovwt0afxH4P0rS5YPEOmWqWUZnu7SXzTFfbfmkNu0cbEcK5IweY/4L2Q6Hqf/AAQT19/BtybjSv7F8Ky6bP5RTzLYXtiY22kkrlMHBJIzXf8A7Nf7VnxU/Z5/Yp+F3i3x7+zdqvif4Zf8Kx0WRfFPgGQ6jfabELCHzje6aVWQxqwc+ZbmX5ANyLgmi65hL4Edpq/jr9k7/gqF8HNH+JH7Mvx28L6h4i8Pz/2n4T1XfHNLpty8Zjltb20ciT7PPEzwTwOBuR2wQyqw8GvrD9g74F6vDovx28V/Eb9mDxFPcFJtF8JePNStPDGpz9WfTzCXs3R8EhBHFMAMMi458v1HT/8AgmzpXifUPj/+x98VvgT4s8J+JrqTVdX+C/xVuF0uaK7l5luNHuZ4jc2LSE/Nb+U8Dt90IevvP7IfijxN41Mniz9mH/gj1pHw7uc7Lbxr4+1GDTreUcfvbcpbSX08XOVPlRK45DCle4zL8EaX/wAE7/hCNX8UfCr9sv42eBxrl79v1TxObrVRptzcEAG4f7fZSWOWwNzbBu6sSea8h8QfG9vHni3TfDv7QvjTxh4ovvjF4NvLq41vwP8ADWTUNZj8ApcNDpdrFbW8M8NhJqJMl5cTsoBAVUCEJs+m/wBsPxf+3No/7PPibSvEPxB+D13Dr62vh26svD9pqFvfWZ1O7h08PBI88gd1a5BAaNAcdRXzYn7V/g/4KfG74i+N/wBnu78d33jXRviCuh+O/D/gTwU2o6JofhPw/cSWZ/tNzCyRTSW0E0yyIyzDzIUBWNTlAiz4d8SfDT9p39nZvhF43+Fx8MeC/hX4nRJPFuoeDnsvFunWkM0a6RpFmj7pY9cuSqlpEJIhkhO0ST4T1nSdFu/CTQfCC00TxV4evLu3F7afBH4HyxLrQhlJ23fiTXZXBjmkwWJE8OSHAe4xmsbwjrPiDwN4Ps/G3irR01TXvBXgi18bvpEmSmqfETxVcSR2Il7n7OG8hAc7VuFIH7tMfav7NvwE0j4AfDpPD5vTqfiDU5TqHjHxLOM3Gt6pIAZ7qVuvLcIn3Y0VEUBVApibR+cvw68DfF+f/goN8Tfhvdfs+fEea30HwD4f1AeHNB/aSv21LTzPJd77lJZriOK5lkCqGiMgUeWuGbNepeIZNO8UWF14j1XxL4s8V2Hgh1k1i81jS1034n/DPcCRepJCijUrIYLMhRxJGjfNdAbKm+C8Hh7/AIeyax+2X471waKPF0Ov/DuyWW4aO1WbS7qwis7OUn5BdT+XeXKBsFkdFQHB3fSH7bXw/uNL8IL+1Z8O7JU8a/DO1l1OBolw2saTGPMv9Jl/vxzwo+wHISZYnHK0rDufJfhLwD+1B8YfiV8XPhx8WfjX8Op4PGPhnRtYg+Ic1lNEyaJp8c0ml6vp0KuYpx9pKSzhpY/Il8wqGSWIjkvgb+1N4l8Z+FdA/aN1/wCOmu/CrTvFuo2+ifHDVrHw9aW0t5M8Ux0PxJbJcRyxW0V/DGtu8wjdiywoADHurR/a3/Z+8G/E/wCGHiX4QaTr1zp3h/w54l0PVPCk1pcyxCPwn4vl+ySWZWJ0MtrBqKm48jdsMdtHGRt4q18bvEPiv/hpb4i/s2a98T/h5feLF/ZhGsafpXg7TLiD+wdW8P3xvNLhUvK4BYzySbSFcJbAhQpOQDr/ABL4f/4JraR4yT9ofxt+3F8XrDX7bTzZ2/jfXdc1OIQ25OWWF57MW8IY/e8pVDYGc4FMsPDnwl/aTubO6/YnvPE3xO12diLb43/FnU7vUdD8KIfle8sIbvbFc3oGfLFtDtD4LyIBg+8+B/iB+338Q/BWl+OdHuPgVrNvrWkQX6+GTNqls5hmiWQIbrMwyVbGTb4z2r5n/aR8Q/DLwL4tmi+M3/BFTR9G1K7BaXxzf63ZweF5JCeTPqNlCzIM8/v4Iy2PWgEe+a9+0f8Asb/8Ev8A4VeF/wBlX4XXreJvF91MLDwl8O9CvY7zXvEGpTsXa4uMH5DLKzSzXMu1Rlm7Yr4d/wCDimw/arj/AGMfh38U/wBqDVPBcF7bfGHS7rSfDfg7T7groo8i43Ry3k0p+2OfkBdYoVBQ4BBr0z9mvx9/wTP/AGRfiRF+0d8Q/jX8PvG3xS1WI6T4L8G/Ajw69/p+iJLgtY6dBaI7T3UpAD3VwRK+No2J8lea/wDBx/8AFP44/GD9hXwnqfxG+Ap8A6Jf/FLTE8OabrWsJPrVw3k3BaS5ghBitRjbtjEsj9d2zpTb0CPxH6zD4n+BvCtt4X0Xxb4otNPvfEkSxaPFeTBPtcyxBzGhPBfbkhepwcZxXVZGdueT2r5//arh+MOtfCnwZ8K/g1deBLPUvF00elX2qeO4FuI9OtDamR7i3tSw+1zhokCw5C5YMxAQ1c/Zs/YetP2dPF9l45l/aP8Aih42v4PD02lXEfjfxU17asJZLeRpYrfasdu263UAIAArFemKpbEH4yf8Ff8Axdd/B/8A4Lq+PPEelyeW+o/DDTRIwOM7ha//ABoUVi/8F69Pl8S/8FrfFNjactB8MdK3bfpH/iKKye50xinFH1f/AMGyxHg/9pP9r74Py/JLpHxKEnlf7P2u/iBx9I6+urzwP/wUiv8Ax1pnifwP8CvgLo1n4fl1G2057zXr5nureVgivLDBahYn2xqxRZHAYkbuK+RP+CVJHwO/4OKP2tPgNcnyIfE2ly63Zxtx5jC6triMDPX93fSN9BX1D8VrH4u+I/2mda+Ff7Bfwu8TeHdU0ye/Pjfx9r+p3Vj4btNSvXtb1LqOIs41aYK8/wC4SMRhpsSOmONI7GE9yP8A4LJ+BvG/ij/giF8RND+IWm6dF4k074eWF3rltoqf6JHe2z28k6wA9Ig6PsH90CoP+CaHx2/aL1D/AIJf/BXVPgx+zbaeM40+GdjELu78bW+nLLcQhoJIQrxuQQ0ZGTge9fQHx/8Agr4x+J37CXjf4DeOfGCeJ/EOsfDnUtLvNZj05LUXt69pIqyCCMlY8yFTtFfB3/Bvj41/aj+MH/BJrwd4A/Z7+J3g3w1N4J8Q63o+sXnibw5cancoXu2vIfLijuYUUBLojLk/dA24FD+Ia+Eqx/tBeKk+Ot/4e+H/AOyD4u+BfxPnvpJrzwoPHPhqPS9Tuc/NdRWertFBcbz8zT2DbnJBdi1e0Gw+K+mWEev/APBVX9r26nbVZinhf4I/C/fbzakuMhbhdM/0vUZG53RxsLdR94uORX+M37N//BVLW47zw38ffit4Y+Kfgq4kLRW/hL4UaHPdwj0kstXlWPI7PHNI3+wK5r4LJ4H/AOCfeoWvw+/ZG/4J1eKr34t/EvUvIOt+N5NE0ozjG6S4kjsJpHtrCAKrMkFukQ+UbjI67pBEvx++HHhbSvA2jfEfwP8A8EjdJ+HOjeHvHPhrVW8ean/YNpqtpaQa1ZSSytb2rSXHKKwZXcNhiWHBrgfFvjr4l/DP4e/ED9nL4E+MdV8c+Jvid8TfiLa6n8M9P8MWlxqjadJJe2cmq3F4vkiBVuYxIjykBlnWJciMV7x+1N8GpvGXhu4+Dvxz+JXjD4rfGHxnoky6R4J8E63LpGi6GGXaLt7eKRUhs45CpM960zyFSEVj+7ryz4Za74i+F/xU179oWP4t+G/hVd/FD4eXDfE7V5vCkd5e6L4o8MJbw6haxyXEvlSiRftkoQxZdEWQZ7AHU654z07XfC3ir4u6VGZ7D/hGfhX8UY44UyX0jTrlGvVUdSYo7SRyOxIHU19R/tOftcJ8H7Sx0D4eafo+p6zqPh+412bUdb1M2ukaNo8BjWTULuZFdzGWlRI441LysSBgKzL8Vfsf+LPjjefC3wD4g8ZfBSTw94vXR73WfAnhbVZEjTxp4Q1DbPqnh5MkpHdRSAXFtC5yIhb7iAZisPjXwv4401Y/FXwk8F+Ivi18EL/wnP4S1rTvCG1vG3gOCO7S8s7eXT5sNNLY3SuEXmQxEK6N5aNI07BY8t179qv4PeIP2k/jV8HvHvxpeDxf8V/Dmnr4m/4TPw/L4X8I+HFEEaQatYWFzJNe3V+sQSVZWEROxWYoFyP1I/aI+IvhrwF+x94s+IP9tpq1hb+B7l7K8SZZf7SZ7YpAEZeJGmdkVcfeaQAda/HfUbXxVon/AAUgn/4KA+GfjP8AFDxj41vbS0spPBvg39nTWbPVL6GJYYpLS6S7RreBJo4gsrk4TczIoKgV9lfDX/hbfg/4WfDbwT8fvBC21zoV02ofDn4I6bOj6r4h1v7Q88FzeohZLHS7J5B5YYkIscckpV1SGkm0xtKxX+Lfw9e78KeKPhFqLSyTab8PPhP8Nbhbad45LjVJNZeeeNHjIZZI4LiOQlSCofcCMZri/D/wgg/Yz1nw18AfGXwX0fStW8OfDHx3468S+L/Dmsx6jP4huU06Sy+1X7TFLmKJo7p8b1kUOYIlY7XI6PxV8AviB+1z4U8VfDr4SfEeDVtb8A67NrXjHxPoviRtO/tjx3ctGlxFZTxkmGLT7FpreJn+USPCjA+VJXmEPwm+EfjTVvEev/sq/BTxFf3fjmST4a6lpeteKpbrxP4gtbK9ivfElzcXV3O5iiSC1htIC8ihpLlThFlQ0CPYvhD8JPgx8Mfgl4Ss/wBof/gklqnhCCx8M2Md18SvAMOn3t7DKtuga6kk0iVdTiJILF1RivfpXT6zqX7cugeHIvH37HP7VWl/F74PXVq219ROlz+IdKwcGL7bfTQ29yqjgm5ImXGH3nk9h4Kv/iXofwuvPi3+wF451jxZDorvH4i+CPxR1SaS9tp4smWziuZ991p15jO2OZpYHypUKrCSvnzxj8KP2ff269YtP2tPh/8AsFeP/DXj6/i8jXbu38H+Gtesbi5RsSQ31rd3ewXMUgZGd1gnUqVfj5aALX7MX7SOsa38e3n+Av7B3i74teOLYNFrHxC8TfEPQ5bHQoiRvihuLDfp9ozfxQ2v71sZcHg15v8A8HFnjj4p/FPwr+zp8GviP8Hz4TvvEHxutDa2i6/BqAu40RY5GBiA2hWuEHzDJyK+p/gv8Ff+CxENzE7ftFfDjwX4TtIQml+GdV+GNrPeFR0EsenXEcFsuMfLHPL9V6V8sf8ABQi3+MXx2/4LXfsW/st/GjVvDmrax4Sv77xPqlx4Wspre1eDzFuMtFNJI0bGPS8EbmA3jB5p6satc+//ANqv4X/Fjx38S/hppHwj+J+peC7nT7bVQ/iXTfDNrqotmZLVUjliuMiNHAkHmgDaVClgH53vgN8IP2tPh98QZtW+OX7W1v8AEPQn0aWC005PAtvo8ltdGWFlmZ4JXEw2LIuCF2577uOK/bY8L/siePPGP2v9qPRfENpYeA/CUusXvjSw8TT6TZ6HbTyOoVp7W5inM0rWpCoitnaOhIpv/BO/wn+z/LF4g+J3wD8YfFee0voLWxufDvxYv9Ye60zYZJklii1Ym4jjmSZWDZKuEUg8YFmZ+X37S3w+X9pT/g4e+NPhWOITJoPw1s45CRkKyjSyB+Uxor1T/gkPo9l+0h/wXD/bQ+ON6ouNP03VJdEtrkcqyrqHkxEEccx2AI9qKysauTjoi1+1mf8AhlP/AIOjfg/8Ypc2+mfGDwpBo91OTgSXTRS2AU+vMdmB7kV9t/t7/GK4/Zl0K78b3/xy1ldS8XXlvpPw6+HemXdlYf2lqZj2srXcsTSRxY/eyyhlEUcZIOSAfkX/AIOn/hprvhf4S/Bn9uvwLA66z8JPiZavNcwr80UErLNFIT/s3NtCo95jX2d8XPjR4t+IHwb+Fvx5/Z0+EXgHxXqXjZbRNH1TxxfNa2ulRX1p56SCeOCWTDMiR+WoBkd41yMg1a0diHrFMs/8E9NP8O+CvhVd/CK8+PN98RvF0Ev9teNfEN5dz3EMl5ftIWit5ZixMEfkmNEDMVRULHL18L/8EUvHHhb9hj9uL9sj9iX4n+IrXQdE8K+Iz4z0ubUJRFFDpzsTJLk9FEM9kw9Q1fa3wpk/ag+G/wC0r4YsP2nP2jfDXiC+8a6LqNvZeBPBvhg6fp+lJbLHP9rRpppbibHMLPIwGZYwFXJFfF//AAU403Tv2G/+C4vwG/bo1awiXwX8W4F8E+PpbiFWgEqlIY5ZQePlR7aTJz8tqcDK0Pe4R10PoHxx8Wf+Cjf7cniubTf2bPgzJ8PfhBs22XjLxd4om0XU/Egzn7RHBbwveW9qQBtANvK4O7eqnbXM+MvhH8c/2U3Pg74N/HX4eWnxa8aQCz0jw/4R+H1xfa7egn/j4udT1bUruaOziP7ySeaMou3CqzsqH6J/4KW/tFePv2dP2VNRv/gfYTX/AMRPFOo2fhv4eaXZRJJPc6leTLGHjRyFJih86clvlAh+Y4ryD4QfsS+Kv2e/hNq3xV/aQ/aOPw7slsjf+MbrwZdI+q34Vcs+q6/exyXV3IeRttltkUkLEo4ymCehoReFJv2S9E8L/si/D341SeIf2hPjLe+Z4t+I+rBLjUxbwxl73WHiORHDBGPJtoTtiV5IgAQHz4T+1l8Fv2cfDujfEz4Qro+qa78Eb6wWw+MXj3XtWkvD4b8ayfubfWoZZX865uFDxrfJCQqKYhj5ZI6nM3gf4HfECD4keFNG/wCET+JvxwurTwN8F9H1e7lvfEtnpl5cp9t8R6rJOzzCZo1WVEkYiJIIY8bmkUekfH7TdC8CeNdT+D/whg006Z8DvB3h6Lw3puqqLi2j8VeINQms4tVvkY4uZYIU+0Bn5MlzI5yxBCGjzD4km4+MnxH+EnwT/aS/av1m38d3/wAWrbTIrPwpdDTdI1LQ0s9QvtO1bR4QXWJnEVtGbqKRpUdXhZgr7G1PFXxKvLX9qay+Do8C+LfHni7UdQ1LTPDnxX8CyS+Ddf1L+zUb7VFPJKE03WRCV2F2kUEnKwYO+rVh+yhpvxD02L4J/sRaI3xJ+FukJIfEOofEnV3h0xNUUk/afDWpwRm4tL7zss8lups0O4KFfIrF+Jnw8+LXw9sPA/gvw54s8XfCCy+GfiqPXPBcfjr4Z3fiWPQ2EckM1lb6vpNw8U+nSxTSRFLlRKEcKGUKAHsC1N/Wv2uvEdl8VtO/Zt1r42/tHS+NNWv/AOz7fwb5/gezu5JvIefymuomBiJjjYhwVJ42ncyg894s8a/Ef4ZfFrUvAdz+zZ4t8KeArF4I/jt4v8GatP4l8XJb3FuJ7cX+pPm4MDIcyJYrM0SN8kqnKDm/iPrHhr43/DDWfhx45/ao+BE/iDXvG1z4q0/xX4V0nWrfXPC2rLMPLnsliR3neJEiTkRZ+ZXD5JPqPgn4XfG74m6zquoWHj/46fFnV9c0+xsbnWL6K4+Hfh5I4ImQtcHes04ctuY21uXIyM0gskeNeIbP9g7xxpnxc1n4NeGvCeqeCfs1pdj44ajdX2laf4T01oVtU0q3jgZZNQubd4n22wMBdrhBJubezeufsjfs1i8kl8O+H7jxF8Ivit4I8JwD4JaHc3oeBfCwEbh7hI3MOoG8ujuv1b95FIYlXbsjkfC+IPw0n+Fnga9h/aQe38J/Eb4Z2l7rXwj8EWNrGvw/1GxtYZXktLKKRSL2ea181J2uj9rVnaSMIoy3qPh7ww9z8Pfib8LPhbqkg8TfAe+s/GPwcmmctcWenXumJfRaS7H53tWYXlmUzjyTGPvRqQAWPHuneLv2tfhbp37dn7DPj688F/F/w9/oHxE8M6IYJ21drRzHeaJfQTjy3uIWWX7PLIoPQBwkgYYugfs4/Fb9pXTpf2gPgJ8f/hhrfiG7kH9qaxomg6z4N1mG7UANBftp+pyr9oTBR0ubZipBBTAxXIfC+5/ZU8ZeOZf20fh/4q1DSPhv8ZL6DUH+IPgTX5NN1LwT4inVEnsNXWM7HtZpgHRriORYp5JAwCTIa3/21f2Vv2zP2c9Pu/2wP2ZfEkPxC8TeF4Fv2v4LGLS/EmqWsR3PaX32NUs9bgaMMCrwRTrnfHIWVVIgPTvgD+2D+1Z8DPGKfBr/AIKTfBweHtPvbyO18IfFzStXi1DSNQkchUtL+WKGH7JOWOFkeKKOTgcMPm+Zf2KH/wCGxf8Ag48+P37SFs32rQfgx4Zh8KaTdD5kS6YC3YA9AS8V/gjqB719zfHz9sL4OeHP+CeniL9tOSW01Twp/wAK6l1+whuY0kS88y23wW5VsqWeRkj2n+I4NfJP/Bu18K9V+AP/AATb8RftifFCxkk8Q/FnW7/xfqTP8stxbIXS3UE9N5Ejrk4xOD3p7tWBaJs9h/ab8bfsNeJv2n9O8QftXfCPXNP0jw5KLew+JXiHU2tvCl7qliJbqOymhFyEuZoN08kTTQld4kWNiwxXqfw1+LXgnSP2bvHf7YFj4013VtKurTU9cTV/EuiHTpRZWMLqixwNHG6W48mR4zIu5xIXyQ4NfP3xL/ZF+B97qmq+N7n46/GH4e+LfDetW3ibW9Ps9VfxFoWm6tqTyBZ47bUbSa2JBuZNwtkhZFcnCggmj/wXl+N/iX9lH/gjR4i8HeLPHMmreK/F+mWfg+XWGiWJ9QnuVxeSKiYChoUuPlHRTjtVvRERu3Y8u/4NQ/h/qdz+zD8V/wBp/XrZlvfiV8TppBM/JkhtoyRz3xNc3FFfYH/BHb9nR/2Wv+Cavwj+FN/Y/Z9T/wCETg1PW42XDLe3g+1Sq3ujS7PogopR2HJ3Z1n/AAUb/Zis/wBsb9h/4l/s7yxK134g8K3K6LI4z5WoRr5tq/0EyR59s18bf8G6/wAatB/as/4Jeah+yj8ZtBGq6n8KtRn8Na5oV0+2ZrQu09oDypQqQ8aNkFWtxggrkfprX45aK/8Aw6K/4OILzSrwf2b8Kf2poDJbN9y2ttTdyQMDgbbxmX/YS9HQdU9HccdVY77QPi94R+DHxduZP2cfhHpfwO1PxD4bm1CX4r/tP+PL2+1S70i2uFL21laXV1PLBA7j5VlmhDbJHEblN1e+f8Fav2ZIP+CmH/BLDUbnwPo06+Io/D9r418CwyKRPHexW/npAOhDvE8kP+84PavQPiR4O/Z0+D3xa8ffEj41+ANc8bXnjO0sb2Vrrwa+qWWk6VYoscVor+W0MCJcPcXJ3lTuuWbJ2kj0P4DftQ+Dfj54t8X+A/CPgTxDpzeBr2HTtYu9TtrUWf2t4xIbWKS3nlDyRoUMi8eWXVThsqG1dEJtHyt/wRj+JHhv/goL8EvAf7aPxN8c6jrfjfwDoR8Jy+G7wRpbeHdUihWG8vFjRQzXF1FscvISUSRo0wC2fRP2hfAWqf8ABQb9pC2+A2k/EDUNI+Gnwl1W21Lx7d6FIqza14g2CS10pZiD5a28TrcSsvzK8tvtKuu5fjHxZY+If+CLn/BW3WNH0fxO3hT4HftXNL9j12KzSa28K+IyW2uIm+TCyy8BsL5dwDyIStfevxoh0P8AYY/Y+u/AvwCtpbnxf4p1BtJ8HyahP5t3rfifU2YLeXMnWV95e5lc8COF/uqoxOtrGj0dz5f8e/EL9m3wb+3Tofwu/ZF+FNvrupfD3ULrUNcg0q5a91TxZ4ma1e2trWa9maSUWtklxNNc3U7mOJzGgJkUpXgfx4s9b+NP7OP7V3gj4SalJ8Ufib8TNd0TTtbXwjDJdRmbSZWudTvI1i3NHY2/nNYQH78zWYC7nZjX29+zh/wSE8OfCn4VL8NfiD8Xria31C2VfFlt8PtITw6PEMp5le/vImkv7wyMWLl7kBtzDaAdtfSXwt/Z9+CP7OHw0l+H3wH+FWg+EtGhtXxYaDpsdujtsI3uVAMjnu7EsTySTRZhzJHwP+z3+1v+0T8L/BtnN8FviBpXxC8C6bZx/ZbfTZz4m0+0tAoKr59nFHrGnIE5/wBKtLwRgDLkc16N4A/4LbeE/iB4StPFlv8ADXwZYrcGRWtdS+OWiWs0bRyNG26KcpKgLISN6KxUglRnFejfslfsrfAL43fsLfBjWfHvw5s31qD4ZaIbHxNpjPY6tZt9iiw0N9blJ4iOPuuBwMg1xv7IP7H/AIjuPD3jbwX4b/ax+IujaN4R+Jes6LolhCNKuSlskqzAvNdWUksrl55CXdyTmjUTaZhaD/wU4+F/hzxVd+LtM8DeBRPdiQiCT9onw+0Nu0jB5miQyfIZGVGfsSuQAS248Q/8FmdZ1zxjY/CL4T/Cfwzd+ItX024vLK40vxunidIkheGNl+yaJFNNJKTMpVGMKEK5Mqha94/4Yl8b/wDR7PxN/wDAHQf/AJW15P4F/Yt8LfE39sfxv4d+PXxa8beN7PwR4Y0u30a2vtXj06OWDUjJNdQXKabFbC6iZ7O3Ply7k/djINGqDQ+Qf29NT/af/bj+HOq/s1614qtvFnjLxD5cOg/DubWY7SWzczRq1+dJ0Yzm3S3V/O83U75lXbjygxxXrPhv40x6L+3vf/Fv4U6fJP4u8Q/CvR4vE3wqvplt9Q1G0slkt9T0qOGUjbqdm32a5hU4E8UswUlXDr9VX3w6+FPwg/bi+Efgz4Y+CNC8N2Q8A+KzDpmiafDaRkCXSuQkYAPfnHrXe/tBfsW/s0ftO3NjrXxc+Ftjda9pMqy6H4t08tZ6zpUq8q9tfQFJ4SDzhXwSBkGhIOY+I/2DvAP7E37Unh3xN+yl4nghtPHPhyxurDSfFGg3cml6lr/htndLcXUClTNPaRulpcWt5HJsaNSyFZVJ+ov2Dtc8cfCWLU/2Fvjj41bXPFHw7tIX8Na9dII5vEXhlyyWV4yjgyxFGtpsZ+eEMf8AWCvG/wBqj/gn38TfhN4h0r9tb4KfEC18T+LPhpfR61K2v+E7dvEWsabCP9L00anaGFrhZbbzEC3McxLbcOp+avYf2ovGP7PEvwI0b/goxN8Un8NW3grw5/bui+N9NiSVrjTLlI3ksJImIFxDcfu18kkESiNlKuoNPYHqfn1/wWJ+Gt9q3xk+H3/BF/8AZY8famdN+Mvju38TeJfChEclt4S0sSyPOIWVfNS3llMt0YmYqht8JgSFR+lHxt+CfhXRv2X9K/Zx0P4RTeIvANjYWmleIPD+mavNZ3qaNBGAv2YwFZJJA0UXyK6F0EgBLEKfiv8A4IQfA/4kftM/Fr4h/wDBaf8Aaa0dofEfxTuZbD4eadd/N/ZWhRsqB4933QwiSJTgZSJiOJOfY/iD4s/Zh+O/7Ut94P8A2jviD8afg/4tuZxpHhKxPj3VfDWl+KbGF5GhntJbOZLe4kcySN5Tt567wCgzRHuEux13wh/YZ/4RzWdG8W/s9/th+MtR+F+sa5b6t4h8EeKLuLWor4QxIIhDfXCG9hKNb2qFHmYbImUjcK+Lf+Czt9cf8FA/+Cvn7O//AATD8OXDXGieFtSi8T/ECOA5EUb7ZnD4+6ws4SFz0N2vZq/RfwD8Of2fv+CfHwD8YePtJ8Z+IT4Uso7vxJr2oeJ/Fl3rDqyxFppUlupJHy+zJUH5n5xuJz+f/wDwbo/DTxj+1L8dPjV/wWK+M2kuNS+I+vT6T4MFx8/2ezSRTP5ZPZRHb24IwMQOB1IA9dAj1Z+s9ra29jbR2VpCscUMYSKNBgKoGAB7AUVJRVEhXw3/AMF+/wBgTUv23/2Hr7W/hxp7v8Q/hpMfEfgqa2yJ5Gjwbm2QjkNJEmVA6yRR/UfclIwDDBpNXQ07O58J/wDBPH9sTx1/wVZ/4JZrcfDb4pWvhT4oWVivhjxnqNxp0dy1lexrGs9x5D5H76BjIhIwHYj+Aisa5/be+E37OGgeDf2EP+CdHhBp0tr2bST8QPEWlXz6Fp1xbgz3wklhhebUL7/WPMEUIjsxmlj6V81fHvTdZ/4N/f8Agq/B+1L4V0q4X9nH49Xf2bxlY2kREGhak8jO7BVzgxtmdAAMxyTRgfKDX6HeMvBXgLw3+0n4O/bL1z4paNb/AA50fwbqVl4b060tR5f9taxe2khvIniyZ2uUVkCgEl34yZMUosJR6op/tifsz/AL/grn+xLrnwem8T6XfR3cki6P4j0uTzl0jWrVyokRsA4WRWRhgb43P94V8l/8Eb/j74h8cftFp+yJ/wAFDNZ1C3+PnwE0C40XwlpWrTL9j1TTyyhtWttwBnuzB5cRk5Jg+Zcb5a+1fDf7bXgnxV+0D4b+B/w9+FmvXM3isapdXetXVrHYrZwWCrHNcT28pFyn74wwKJI0YtICBtUkeR/8FZ/+CWt5+2PYaN+0j+zP4nHgr4/fDtlu/BPi21byzeiIlxYXDDqjMTtZshSxBBVmFDXUaelmfalfMH/BUL4UeMfix8P/AAfptld+OY/CVj4mkuPHSfD1fPv2tPsVwsDNacm9gW6MDSwBXLxhhtNcF/wS3/4K16f+1beXf7K/7VXhv/hXX7QnhDNr4o8F6qPJ/tNkHN1Z7uGDKA7RgkruyCyYavtynuhbM/Or4ZS6j8BvA0fjv4W/GO+0DwbAhNv41+GiS694PijT78WqaFdNJc6MUx8/2aRUQBtzxkbRk/sd/t6+PNG+HmteM5v2iP2WkPjbxjqPiNIfEHxLuNNvI47iQLGZLVYpvs5ZIlk8syOyeZtY5BFfX/7QP7D3w/8AjFBruveA/EupfD3xbr+mT2OpeKPCyop1CGWNo2jvbZ/3N6uG4Mi+YuPkdDzXN+Dv2V/2x/BXhHSvBml/tZ/Dx7XSNNgsrZ5/gWWdo4o1RSx/tfk4UZPrU2YXiee/8PIPHH/RxP7IP/h5rr/5ErxU/tieJLn9r7XrfxJ+1/8ADnR7L4keG7FLRvgNM3irV76508yodOt/Mjza3EiXG9GNvKGCvtZCnP19/wAM+/trf9HXfDb/AMMQf/lvXNeOv2HP2nfir4i8K6p47/bL0bT4PC2uNqdvN4H+FEWmX7O1rPbMqXE19crHmO4f5vKYg4IwQDRqO8T5x+MHwQ8D65bzaBP8PtV0Xxnq0BvvC+iaXdnXPidqdyit9nvL7U3kYaHbCQgsElC7SU81CTHX6IfCTT/GGlfCrwzpfxCuWm1+28P2UWuTPKJDJeLAgmYsOGJkDHI69azfg18APhR8A9Gn0n4Z+FktZb6XztW1W5me4v8AU5+811cylpbiQ/3nY+2BxXYTzwWsD3NzMsccalpJHbAVQMkknoKpKwr3FmeOOJnmYKgUlmY8Ad81+KXjr4dP/wAFZf21tX/4Jv8A7KvjLVh+y38P/Hc3iT4narBKPsTX7vufStPlQYa3NwJnjXJCtNK6/JHGK9l/bh/b3+Nv/BTf4w33/BMT/glNqzyaczm2+MHxrtCxsNFsW+WW2tpBje7DepdGy5BRONzj7J/Zp/ZI8B/8Ezf2Nz8IP2UvhTP4l1DRtMe6+xLdw2134n1YxgNLPPKQiNI4ALE7Y1AAGFApfEP4UQftc/G34J/ss/BzS/gjd/BTxxrWhavp40K30b4a6esa6baGMRJHLdPPbw2KOv7tGaVCxyFOa434XaZ+0B+0vbah8B/2nf2L7mb4NaxpbRW+ofEbX9JudYg+U7Ekt7R5kmA42zbllQhSTIQXq54I+OXwc+KXhHxV+0j8HtZm0rxNp0Qi+LXwz8WxyR3E88cYT7DdWkzM1tcFf3cMsYaOQMgxKhXHRftJ/Gb4A/8ABLn9m7x5+0/4n1G+ttHigil07wtPqkjRG72bILCxhZmW3EkjFmWMBQWdyMKcVsTqz4l/4OBvjf4j+Is/wy/4IkfsgQRr4l+ItzYDXrWw4j0vRYm2wQSbM+Wh8oysMZEVv6OM/pR+y1+zt4C/ZL/Z68I/s5fDO08rRfCOjRWNqSoDTMozJM2P4pJC8je7mvzy/wCCA/7IPxR+Kvjbxf8A8Fj/ANsKyeXx/wDFe5nPgq0u4v8AkF6LIVxLGD9wSKFijGARDEDk+aa/UupXcqXYKKKKokKKKKAPL/2x/wBkr4Sftv8A7PHiH9nD406R9p0fXbUrHPGq+dY3K8xXUJIO2SNsMD9QcgkV+bv/AASW/a++KX/BO79oe4/4Ip/8FEb+NW0+7Q/Bjxpekm21S2kk3wWokc42sSPJ7o4aE4KoK/XKvlr/AIKrf8EvPhT/AMFNPgV/wh+uzpofjfQN914D8ZwRnztMu8ZCvtILwOQu5O2Ay4YA1LWt0Un0Zs/Dz4Uj4I/tc+M/ir461O31nxb8YL5bDwjfWejNFb6To+nWBljtrh8kea0pmZ2DAzfIQqiMhfMf2NP2u/HHgf8AZN8P/tUftR/E+71Dw1q2ilPFeoam6S3Nv4mOqmyNpYwQRgvATuAjUMfkj2Biz18//wDBPz/go94jsPF0v/BIv/gs74aj0n4g6S6WXhfxZrz+VZeKbdAVgP2j5R5zKv7udSPOzgkSZDfQfxx/Zil8KfGLw9qPim7i8NfC/wCHWlwD4EaF4M8OTT6fpfiVmdFutRt4klaRwrCGEbDFieU5WZozTTuJqxu/t9/8EvP2bf8Agpj4V0n4u+GPFM/hL4jaPGLnwR8VvCEgivbaVDmNZWXDTRKw+6SHQ52spyD8FfHj/gp9/wAF3P8Agl9rui/CT9sHwb8PtU8F28i2cXxtbwLqOrx3sWSsc0/2W/tlEpAG5GRH6kBzyfvTUvjJ4++D37avwx+B/gyTTruLxzqV8/xf1M2jRQz6jHov2iNrOIsfszKII5JQSeLtN25mLL7d4I/aG/Zm/ab8T+Mvgf4R8UaV4un8LSR2Xi7TTYtcWaNKm4RNI6GGY46qrNjuBQ0NS7n5qfC//gt7+0z8bzcJ8Gf2pfhL4tazx9rXw1+yr4+vjDnpvEN223PvXY/8PNf+Ci3/AEO/hL/xDP4j/wDyRXp3x/8A+Dc79gP4m+LW+KPwGj8TfBXxiGLxa58NdaktY1f+99mYmNPpF5ee+a5Ox/4J2f8ABdv4Ff8AEu/Z5/4LDaV4o0qPiDT/AIo+BoppFUfdU3BjuZD9QV+lS00P3Tnf+Hm3/BRb/od/CX/iGfxH/wDkij/h5t/wUW/6Hfwl/wCIZfEf/wCSK7OH4P8A/BzTdj7BcftZfs4Wi9DfR+G7x3x6hTa4J/AUsn/BLP8A4KsfHxfs37YX/BZXxAmly8XWg/CrwjbaMjL/AHftEYjZgR/ejz7mjUNDwn4p/wDBeX9oH4K6g2g/E/8Aaw+EGh6sbczQaNq/7L3jmzupwOm1Li+TqeASQM9xTvhZpX/Bbf8A4Lc+D4fDX7Qut6Z8CvgXd3BbU9T8L+H7rSdb8V2RxiJILi6uHSN16lmWPnpKBivs/wDZl/4I6f8ABOH9h25m+L2nfDW21fxJaK15qfxD+I2qHUb1WAy05luD5UGOSWRU9zxmvV9e/bI8A6P8T/hh4PsNJmvfDXxVhuB4a8fW9zH/AGXNcpbmeC1RgSzyTxJI8ZwqOsbFWJwCKLe4OUVsZHwl+BP7Nn/BMX9m+y+G/wCz98Kzaacl5bWNjZ2UYa91vU7iRYYTcXBA3SSSOqmWQhEB/hUAUn7DH7RWufH3RvFCfEbW57HxtoWuta+LPh9qGnRwXHhO5xxbo6Em6tXQK8V0cibLuCARFF5n4++LP7anwV/aO+IGpeANDvviz4I07UYdR1TwHd2cVrd6LYPZQSB9Mvn2pdSGZbgiyl3H5RtkiBUH1TX/AIc/ALxF4r8M/wDBQb4kWepeAdS8PeE5f7SuNcvjpTLYSBZBBqirIEkWFgXWOQsEdievFXsRe51HxS+Dn7K+l+J2/aq+Lfw48IQ6x4T017l/G2r6ZAJ7C2hUyF2nZchUALAk/LyRivyk0a28df8AByR+39H4n1GxvdP/AGTfgtrBFpFKGhPiq+Pqp4YybBnj91AcZDymrXx1+Ov7Q/8AwcY/H2T9kz9ke61bwj+zD4X1ON/iD8Q5bRoz4ieNgfJiyBkHrHDn0llAwij9Yv2cf2dPhF+yf8GNC+AfwN8JQaN4b8PWYgsbSLlnPVpZGPMkjtlmc8kk1PxFfD6nX6Po+l+H9JtdB0PT4bSysrdILS1t4wkcMSKFVFUcKoAAAHQCrNFFUSFFFFABRRRQAUUUUAfOP/BR3/gmF+zf/wAFLPhV/wAIR8YNHOn6/p6M3hbxtpkSjUNHmJByjfxxkgbomO1sdiAw+EPhB/wUO/bi/wCCKXjPT/2Wf+Csnh3U/GnwplmW08FfHLRkku3ihzhIrnq8gVVbKNidQvyiVcGv19rC+JPwx+Hnxi8Fah8OPip4L03xBoOq25h1HSdWtFngnQ9mVgR7g9QeRzSa1uik+jPmmf4A/s4ftQeAvDX7Sv7LXjZvHVpoB1/VfDunWvjB/sXiC+1NIhLDfXbb5xGPK2GNm4VzGw2AJXpH7A37OF9+zX+zzY6P4wtof+E08SXT+IPiBcQoiq+sXQVp4k2fKIYAFt4lX5VigjA4Ar4g+Kn/AAQf+P37IvxAvv2gv+CK37T958OtRuJRcah8MvE168+iX+3/AJZIWVwBycLMr4zgSIOlbQ/+C9P7Qn7LFyPhP/wWI/YC8YeDHkBtZfHngnTWutHvOMFwC+Ap5J8qWRgCPkpXtuFr7HffscftRftF/GD4322lfDjW/FepPr/xS1nxJq0HijVbeTRrb4freXenwvY+bM1w8n2i2jZViX5DON4VGTd9X/E79rKP4e/tOeA/gRF4WNzpfii/n0zWfEbTbY9N1F7Oa7srXH8TTJbTk/3cwjBMox4R+zH+1L/wRq+NWo+ANf8A2Y/2kPBvh/UfAdpeWXhPRE19dJnitLvaZ7FrS6KtNCzLG/lgHayKVKkV6J8TP2EPAvxh+HSHwx4+0c+PovHNn4qtPiZ/Y8Mt8Lq31BLuNWMTruQRoLUDOFh4A4qiWmd9d/tA+Lbf9tq0/Zdk8Naeuj3fw4m8Txa39qc3DyR3qWrW/l7QqgeYj79xJzjaOtYPwr/a4uPiP+0J4w/Zu8b6EfDc0gu7j4b6vBOCde061k+xXsqbgQLiC8SQlMH9zNA4By1b2lfs7+LZv2p5/wBpvxh46sruex8K3fh/wzptjpjQC3s7mW0nk+0MZG851mtSVZQnyykEEjJ4DXf2Nv2bPDXgvwbrnxV+IOi+GvFXgbxKviJ/iBoZs9Iurm7DTGQTSzCQmCRZmSSNmIdeOBQB81+D/jJ8d/htr9n8SfjHfeLPEtj8K/i3qXgH4wPL4ykuB4kh1K6jtdIm/saQ/ZlQLf6fckwqjgKwCkM9dn4X/wCCfXi7WtC+Jn7Id/Z+IbbTvBmuW+tfs8/EW8vS+n+Fg7Jd21tbwbwRPZz+am9UO+2dYjIoYqYvjl/wVV/4Ii/sl/EfW/izefFXw94w8c6tepd33/CEqddu57qOIQRtGyMbeKQRjywwdMLwSBXkGof8FLf+Cxn/AAUwZvDH/BNT9jS4+E/g2/Gz/hanxWh8qTyTx5sCsrRg4IOY1uCMHBzyFzIFBvc+wv2rP2xf2Sf+Ca3h26/aA/av+MFvH4s1bQLazl03S2lWbXHt95X7LpwlcIS8jDzGJCggNJtFfBmm/C7/AIKE/wDBxN4ttPFvxvt9X+CX7KtreLPpXhm3nKal4rjU7o5HBxv3DaRIy+Um792JGBavoX9jL/g35+Cfwu+IS/tL/txfETUvj18WJ5kuJ9Z8WyPLp1nMvQw28hJkxwAZSQABtRK/QmGCG2iWC3iVERQqIgwFA6ADtSs2VdR2OO+AH7Pnwc/Zd+FWlfBT4D+ArDw34b0eHy7PTrCLaCerSO3WSRjyzsSzE5Jrs6KKokKKKKACiiigAooooAKKKKACiiigAqnr3h7QPFWkzaD4n0S01GxuF23FnfWyzRSj0ZHBBH1FFFAHyZ8e/wDgg3/wSn/aGnm1LxZ+yXoukajOxL6n4Rnm0qTcerFLd1iY+7Ia+KP2gf8AghH+y9+z+t6/wU+Pfxs8Mx2iloINK8fIiLjtg2xOPxooqGaRbPmH4f8A7KPiPx38Q38Aa5+2j8dvsEcwRTF8QcPgnHUwkfpX2t8BP+Dc79gj4sOmt/Gbxh8VfGLwjf5fiDxyXVznv5cKN+RFFFI0lotD7X/Z5/4JO/8ABOf9liWG9+Cf7I/hHTr6AAJqt9Ym/vAfXz7ppJB+DAV9DIixqERQABgADGBRRVo59xaKKKYBRRRQAUUUUAFFFFAH/9k='>
</p>
<p>
  <br>
</p>
<p><strong>ใบสมัครเข้าร่วมเตรียมสหกิจศึกษา</strong></p>
<p><strong>ศูนย์ฝึกประสบการณ์วิชาชีพและสหกิจศึษา คณะวิทยาศาสตร์</strong></p>
<p><strong>มหาวิทยาลัยราชภัฏจันทรเกษม</strong></p>
<p><strong>&nbsp;</strong></p>
<p>1. ชื่อ – นามสกุลนักศึกษา/Student name <u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;");

            foreach (var emp in teacher)
            {
                sb.AppendFormat($"{emp.Name}{emp.Skill}");
            }

            sb.Append(@"นาย ธันวา เม๊าะหะมะ &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u></p>
<p>&nbsp; &nbsp; &nbsp;รหัสประจำตัวนักศึกษา/Student ID<u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 5911501335 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u>หมู่เรียน วท.บ.<u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 591(4)/2 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u></p>
<p>&nbsp; &nbsp; <strong>R</strong> ภาคในเวลาราชการ &nbsp; &nbsp;☐ ภาคนอกเวลาราชการ &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; หลักสูตร/Program &nbsp; &nbsp; &nbsp;<u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;4 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u> ปี/years</p>
<p>สาขาวิชา/Major <u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; เทคโนโลยีสารสนเทศ &nbsp;</u>คณะ/Faculty <u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;วิทยาศาสตร์ &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</u></p>
<p>ระดับคะแนนเฉลี่ย/GPAX <u>&nbsp; &nbsp; &nbsp;3.44 &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u> จำนวนหน่อ.ประภาดา นาวากา &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u>อีเมล์/e-mail <u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    <a href='mailto:vathunwa@gmail.com'>vathunwa@gmail.com</a>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
  </u></p>
<p>2. ที่อยู่ปัจจุบัน เลขที่/Address <u>&nbsp; &nbsp;10 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u>ถนน/Road <u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; กรุงเทพกรีฑา 26 แยก 1 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</u></p>
<p>&nbsp; &nbsp; &nbsp;แขวง/ตำบล/Sub-District <u>&nbsp; &nbsp; &nbsp;สะพานสูง &nbsp;</u>อำเภอ/เขต/District <u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;สะพานสูง &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</u></p>
<p>&nbsp; &nbsp; &nbsp;จังหวัด/Province <u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; กรุงเทพมหานคร &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u> รหัสไปรษณีย์/Postcode <u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;10250 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</u></p>
<p>&nbsp; &nbsp; &nbsp; โทรศัพท์/Telephone No<u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; - &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u>โทรศัพท์มือถือ/Mobile Phone No<u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;0827252869 &nbsp; &nbsp; &nbsp;</u></p>
<p>3. ชื่อ – นามสกุลผู้ปกครอง/Current name<u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;อุษณีย์ เม๊าะหะมะ &nbsp; &nbsp; &nbsp;</u>เกี่ยวข้องเป็น/Relation <u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;พี่สาว &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u></p>
<p>&nbsp; &nbsp; &nbsp;แขวง/ตำบล/Sub-District<u>&nbsp; &nbsp; &nbsp; สะพานสูง &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u> อำเภอ/เขต/District<u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; สะพานสูง &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u></p>
<p>&nbsp; &nbsp; &nbsp;จังหวัด/Province<u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;กรุงเทพมหานคร &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u> รหัสไปรษณีย์/Postcode<u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 10250 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</u></p>
<p>&nbsp; &nbsp; &nbsp; โทรศัพท์/Telephone No<u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; - &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</u>โทรศัพท์มือถือ/Mobile Phone No <u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 0902759491 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u></p>
<p>4. กิจกรรม/โครงการ/รางวัลที่ได้รับ</p>
<table border='1' cellpadding='0' cellspacing='0' width='631'>
  <tbody>
    <tr>
      <td width='38.985736925515056%'>
        <p><strong>ชื่อกิจกรรม</strong></p>
      </td>
      <td width='37.08399366085578%'>
        <p><strong>หน่วยงานที่จัด/มอบ</strong></p>
      </td>
      <td width='23.93026941362916%'>
        <p><strong>วัน เดือน ปีที่จัด/รับรางวัล</strong></p>
      </td>
    </tr>
    <tr>
      <td valign='top' width='38.985736925515056%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='37.08399366085578%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='23.93026941362916%'>
        <p>&nbsp;</p>
      </td>
    </tr>
    <tr>
      <td valign='top' width='38.985736925515056%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='37.08399366085578%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='23.93026941362916%'>
        <p>&nbsp;</p>
      </td>
    </tr>
    <tr>
      <td valign='top' width='38.985736925515056%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='37.08399366085578%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='23.93026941362916%'>
        <p>&nbsp;</p>
      </td>
    </tr>
    <tr>
      <td valign='top' width='38.985736925515056%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='37.08399366085578%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='23.93026941362916%'>
        <p>&nbsp;</p>
      </td>
    </tr>
  </tbody>
</table>
<p>&nbsp;</p>
<p>- 2 -</p>
<p>5. ความสามารถพิเศษ (โปรดระบุความสามารถ ดีมาก / ดี / ปานกลาง / พอใช้)&nbsp;Special Abilities</p>
<table align='left' border='1' cellpadding='0' cellspacing='0' width='98%'>
  <tbody>
    <tr>
      <td rowspan='2' width='45.45454545454545%'>
        <p><strong>ความสามารถพิเศษ</strong></p>
      </td>
      <td colspan='4' valign='top' width='54.54545454545455%'>
        <p><strong>ระดับความสามารถ</strong></p>
      </td>
    </tr>
    <tr>
      <td valign='top' width='25%'>
        <p><strong>ดีมาก</strong></p>
      </td>
      <td valign='top' width='26.923076923076923%'>
        <p><strong>ดี</strong></p>
      </td>
      <td valign='top' width='25%'>
        <p><strong>ปานกลาง</strong></p>
      </td>
      <td valign='top' width='23.076923076923077%'>
        <p><strong>พอใช้</strong></p>
      </td>
    </tr>
    <tr>
      <td valign='top' width='46.391752577319586%'>
        <p>1. ความสามารถทางคอมพิวเตอร์</p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='14.43298969072165%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='12.371134020618557%'>
        <p>&nbsp;</p>
      </td>
    </tr>
    <tr>
      <td valign='top' width='46.391752577319586%'>
        <p>-&nbsp;Ms. Word</p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='14.43298969072165%'>
        <p>P</p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='12.371134020618557%'>
        <p>&nbsp;</p>
      </td>
    </tr>
    <tr>
      <td valign='top' width='46.391752577319586%'>
        <p>- Ms. Excel</p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='14.43298969072165%'>
        <p>P</p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='12.371134020618557%'>
        <p>&nbsp;</p>
      </td>
    </tr>
    <tr>
      <td valign='top' width='46.391752577319586%'>
        <p>- Ms Power Point &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='14.43298969072165%'>
        <p>P</p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='12.371134020618557%'>
        <p>&nbsp;</p>
      </td>
    </tr>
    <tr>
      <td valign='top' width='46.391752577319586%'>
        <p>- อื่น ๆ โปรดระบุ &nbsp;<u>พื้นฐานทำเว็บไซต์</u></p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='14.43298969072165%'>
        <p>P</p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='12.371134020618557%'>
        <p>&nbsp;</p>
      </td>
    </tr>
    <tr>
      <td valign='top' width='46.391752577319586%'>
        <p>- <u>พื้นฐาน&nbsp;</u><u>Arduino IOT &nbsp;&nbsp;</u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='14.43298969072165%'>
        <p>P</p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='12.371134020618557%'>
        <p>&nbsp;</p>
      </td>
    </tr>
    <tr>
      <td valign='top' width='46.391752577319586%'>
        <p>2. ความสามารถทางภาษา</p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='14.43298969072165%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='12.371134020618557%'>
        <p>&nbsp;</p>
      </td>
    </tr>
    <tr>
      <td valign='top' width='46.391752577319586%'>
        <p>- ภาษาไทย</p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>P</p>
      </td>
      <td valign='top' width='14.43298969072165%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='12.371134020618557%'>
        <p>&nbsp;</p>
      </td>
    </tr>
    <tr>
      <td valign='top' width='46.391752577319586%'>
        <p>- ภาษาอังกฤษ</p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='14.43298969072165%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>P</p>
      </td>
      <td valign='top' width='12.371134020618557%'>
        <p>&nbsp;</p>
      </td>
    </tr>
    <tr>
      <td valign='top' width='46.391752577319586%'>
        <p>- ภาษาจีน</p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='14.43298969072165%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='12.371134020618557%'>
        <p>P</p>
      </td>
    </tr>
    <tr>
      <td valign='top' width='46.391752577319586%'>
        <p>- ภาษาอื่น ๆ โปรดระบุ<u>&nbsp; &nbsp; &nbsp; &nbsp;ญี่ปุ่น &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</u></p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='14.43298969072165%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='13.402061855670103%'>
        <p>P</p>
      </td>
      <td valign='top' width='12.371134020618557%'>
        <p>&nbsp;</p>
      </td>
    </tr>
    <tr>
      <td colspan='5' valign='top' width='100%'>
        <p>&nbsp;</p>
      </td>
    </tr>
  </tbody>
</table>
<p>
  <br>
</p>
<table cellpadding='0' cellspacing='0' width='100%'>
  <tbody>
    <tr>
      <td>
        <p>Frontend Deverloper</p>
      </td>
    </tr>
  </tbody>
</table>
<p>&nbsp;6. ลักษณะงานที่สนใจและต้องการปฏิบัติงาน (ต้องสอดคล้องกับสาขาวิชาที่เรียน)</p>
<p>
  <br>
</p>
<p>
  <br>
</p>
<table cellpadding='0' cellspacing='0' width='100%'>
  <tbody>
    <tr>
      <td>
        <p>Developer front End</p>
      </td>
    </tr>
  </tbody>
</table>
<table cellpadding='0' cellspacing='0' width='100%'>
  <tbody>
    <tr>
      <td>
        <p>Developer front End</p>
      </td>
    </tr>
  </tbody>
</table>
<table cellpadding='0' cellspacing='0' width='100%'>
  <tbody>
    <tr>
      <td>
        <p>System Tester</p>
      </td>
    </tr>
  </tbody>
</table>
<p>&nbsp;.............................................................................................................................................................................................................................................</p>
<p>
  <br>
</p>
<p>............................................................................................................................................................................................................................................</p>
<p>...........................................................................................................................................................................................................................................</p>
<p>...........................................................................................................................................................................................................................................</p>
<p>...........................................................................................................................................................................................................................................</p>
<p>...........................................................................................................................................................................................................................................</p>
<p>...........................................................................................................................................................................................................................................</p>
<p>...........................................................................................................................................................................................................................................</p>
<p>...........................................................................................................................................................................................................................................</p>
<p>...........................................................................................................................................................................................................................................</p>
<p>...........................................................................................................................................................................................................................................</p>
<p>...........................................................................................................................................................................................................................................</p>
<p><u>&nbsp;</u></p>
<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>– 3 –</p>
<p>&nbsp;</p>
<p>มีความประสงค์จะเตรียมปฏิบัติสหกิจศึกษา ณ หน่วยงาน ชื่อ<u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</u><u>บริษัท อินเตอร์ เซต รีเสิร์ช แอนด์ โซลูชั่น</u><u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u><u>&nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u><u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u></p>
<p>เลขที่<u>&nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u><u>3300/119</u><u>&nbsp;&nbsp;</u>หมู่......-......ถนน<u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u><u>พหลโยธิน</u><u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</u>ตำบล/แขวง <u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</u>จอมพล<u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u></p>
<p>อำเภอ/เขต<u>&nbsp;จตุจักร &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u>จังหวัด<u>&nbsp; &nbsp; &nbsp; กรุงเทพมหานคร &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u>รหัสไปรษณีย์<u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 10900 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u></p>
<p>โทรศัพท์<u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</u><u>025137025-6 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</u><u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</u>โทรสาร<u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;- &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u></p>
<p>ตำแหน่งหัวหน้าหน่วยงาน/หัวหน้าฝ่าย<u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</u><u>เจ้าหน้าที่ ประสานงานโครงการ</u><u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</u></p>
<p>ชื่อหัวหน้าหน่วยงาน/หัวหน้าฝ่าย<u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</u><u>คุณสกุลตรา อุปบุตร&nbsp;</u><u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u></p>
<p>ปฏิบัติสหกิจศึกษา ระหว่างวันที่ <u>&nbsp;</u><u>9</u><u>&nbsp;&nbsp;</u>เดือน<u>&nbsp; &nbsp; &nbsp; มกราคม &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</u>พ.ศ<u>&nbsp; 2563 &nbsp;&nbsp;</u>ถึงวันที่<u>&nbsp; 11 &nbsp;</u>เดือน<u>&nbsp;&nbsp;</u><u>พฤษภาคม</u><u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</u></p>
<p>พ.ศ <u>&nbsp;2563 &nbsp;</u>จำนวนทั้งสิ้นรวม .............16................ สัปดาห์</p>
<p>&nbsp;</p>
<p>ข้าพเจ้าขอยืนยันว่าข้อมูลข้างต้นและหลักฐานประกอบที่แนบมาพร้อมนี้เป็นความจริงทุกประการ ข้าพเจ้าพร้อมที่จะปฏิบัติสหกิจศึกษา ตามระเบียบข้อบังคับเกี่ยวกับสหกิจศึกษาของมหาวิทยาลัยและสถานประกอบการอย่างเคร่งครัด</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table border='0' cellpadding='0' cellspacing='0'>
  <tbody>
    <tr>
      <td valign='top' width='54.99207606973059%'>
        <p>ลงชื่อ&nbsp;…………………………..………………</p>
        <p>(<u>&nbsp; &nbsp; &nbsp; &nbsp;นาย ธันวา เม๊าะหะมะ &nbsp; &nbsp; &nbsp;&nbsp;</u>)</p>
        <p>&nbsp; นักศึกษา</p>
      </td>
      <td valign='top' width='45.00792393026941%'>
        <p>ลงชื่อ&nbsp;…………………………..…………………….</p>
        <p>&nbsp; &nbsp; (<u>&nbsp; &nbsp; &nbsp; &nbsp;อ.ประภาดา นาวากา &nbsp; &nbsp; &nbsp;&nbsp;</u>)</p>
        <p>&nbsp; &nbsp; &nbsp; อาจารย์ที่ปรึกษา</p>
      </td>
    </tr>
    <tr>
      <td valign='top' width='54.99207606973059%'>
        <p>&nbsp;</p>
        <p>ลงชื่อ&nbsp;…………………………..………………</p>
        <p>(<u>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; ผศ.ศรีอุดร แซ่อึ้ง &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</u>)</p>
        <p>&nbsp; &nbsp; &nbsp; &nbsp;กรรมการศูนย์ฝึกประสบการณ์วิชาชีพและสหกิจศึกษา</p>
      </td>
      <td valign='top' width='45.00792393026941%'>
        <p>&nbsp;</p>
        <p>ลงชื่อ&nbsp;………………………….......……………….</p>
        <p>&nbsp; &nbsp; &nbsp;(<u>&nbsp; &nbsp; &nbsp; &nbsp; อ.ประภาดา นาวากา &nbsp; &nbsp; &nbsp;&nbsp;</u>)</p>
        <p>&nbsp; &nbsp; &nbsp;ประธานหลักสูตร</p>
      </td>
    </tr>
    <tr>
      <td valign='top' width='54.99207606973059%'>
        <p>&nbsp;</p>
      </td>
      <td valign='top' width='45.00792393026941%'>
        <p>&nbsp;</p>
      </td>
    </tr>
  </tbody>
</table>
<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</p>
<p>
  <br>
</p>
<table cellpadding='0' cellspacing='0' width='100%'>
  <tbody>
    <tr>
      <td>
        <p>ส่งคณะวันที่ ..........................................</p>
      </td>
    </tr>
  </tbody>
</table>
<p>
  <br>
</p>
<table cellpadding='0' cellspacing='0' width='100%'>
  <tbody>
    <tr>
      <td>
        <p>
          <br>
        </p>
      </td>
    </tr>
  </tbody>
</table>
<p>
  <br>
</p>");
            



            return sb.ToString();
        }
    }
}